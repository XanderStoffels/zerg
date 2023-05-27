using System.Diagnostics;

namespace Zerg.SpaceTraders.API.RateLimiting;

public class SpaceTradersRateLimiter : IRateLimiter
{
    private readonly AsyncRateLimiter _bucket1;
    private readonly AsyncRateLimiter _bucket2;
    private readonly Stopwatch _watch;
    private int _requestCount;

    public bool IsAvailable => _bucket1.IsAvailable || _bucket2.IsAvailable;
    public double AverageRequestsPerSecond => _requestCount / (_watch.Elapsed.TotalSeconds == 0 ? 1 : _watch.Elapsed.TotalSeconds);

    public SpaceTradersRateLimiter()
    {
        _bucket1 = new(2, TimeSpan.FromSeconds(1));
        _bucket2 = new(10,  TimeSpan.FromSeconds(10));
        _requestCount = 0;
        _watch = new();
    }

    public Task WaitUntilReadyAsync(CancellationToken cancelToken = default)
    {
        _requestCount++;
        
        if (!_watch.IsRunning)
            _watch.Start();
        
        if (_bucket1.IsAvailable)
            return _bucket1.WaitUntilReadyAsync(cancelToken);
        
        if (_bucket2.IsAvailable)
            return _bucket2.WaitUntilReadyAsync(cancelToken);
        
        return _bucket1.WaitUntilReadyAsync(cancelToken);
    }
}