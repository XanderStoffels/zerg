namespace Zerg.SpaceTraders.API.RateLimiting;

public class AsyncRateLimiter : IRateLimiter
{
    private readonly int _maxCount;
    private readonly TimeSpan _resetTimeSpan;
    private readonly object _resetTimeLock = new();

    private readonly SemaphoreSlim _semaphore;
    private long _nextResetTimeTicks;
    
    public bool IsAvailable
    {
        get
        {
            ResetSemaphoreIfNeeded();
            return _semaphore.CurrentCount > 0;

        }
    }

    public AsyncRateLimiter(int maxCount, TimeSpan resetTimeSpan)
    {
        if (maxCount <= 0)
            throw new ArgumentOutOfRangeException(nameof(maxCount), "Max count must be greater than 0.");
        
        _maxCount = maxCount;
        _resetTimeSpan = resetTimeSpan;

        _semaphore = new(maxCount, maxCount);
        _nextResetTimeTicks = (DateTimeOffset.UtcNow + this._resetTimeSpan).UtcTicks;
    }

    public async Task WaitUntilReadyAsync(CancellationToken cancelToken = default)
    {
        // Attempt a reset in case it's been some time since the last wait.
        ResetSemaphoreIfNeeded();

        var semaphoreTask = _semaphore.WaitAsync(cancelToken);

        // if there are no slots, need to keep trying to reset until one opens up
        while (!semaphoreTask.IsCompleted)
        {
            var ticks = Interlocked.Read(ref this._nextResetTimeTicks);
            var nextResetTime = new DateTimeOffset(new DateTime(ticks, DateTimeKind.Utc));
            var delayTime = nextResetTime - DateTimeOffset.UtcNow;

            // Delay until the next reset period
            // Can't delay a negative time so if it's already passed just continue with a completed task.
            var delayTask = delayTime >= TimeSpan.Zero ? Task.Delay(delayTime, cancelToken) : Task.CompletedTask;

            await Task.WhenAny(semaphoreTask, delayTask);

            ResetSemaphoreIfNeeded();
        }
    }
    
    private void ResetSemaphoreIfNeeded()
    {
        // Quick exit if before the reset time, no need to lock.
        var waitForTicks = Interlocked.Read(ref _nextResetTimeTicks) - DateTimeOffset.UtcNow.UtcTicks;
        if (waitForTicks > 0)
            return;
        
        // Take a lock so only one reset can happen per period.
        lock (_resetTimeLock)
        {
            var currentTime = DateTimeOffset.UtcNow;
            // Need to check again in case a reset has already happened in this period
            if (currentTime.UtcTicks <= Interlocked.Read(ref this._nextResetTimeTicks)) return;
            if (_maxCount != _semaphore.CurrentCount)
                _semaphore.Release(_maxCount - _semaphore.CurrentCount);

            var newResetTimeTicks = (currentTime + this._resetTimeSpan).UtcTicks;
            Console.WriteLine($"[BUCKET {_maxCount}] RESET --- NEXT IN {_resetTimeSpan.Seconds} S");

            Interlocked.Exchange(ref this._nextResetTimeTicks, newResetTimeTicks);
        }
    }
    
}