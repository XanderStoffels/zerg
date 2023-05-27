namespace Zerg.SpaceTraders.API.RateLimiting;

public interface IRateLimiter
{
    public bool IsAvailable { get; }
    
    /// <summary>
    /// Waits until the rate limiter is ready to make another request.
    /// </summary>
    /// <param name="cancelToken"></param>
    /// <returns></returns>
    Task WaitUntilReadyAsync(CancellationToken cancelToken = default);
    
}