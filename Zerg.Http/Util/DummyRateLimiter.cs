using Zerg.SpaceTraders.API.RateLimiting;

namespace Zerg.Http.Util;

public class DummyRateLimiter : IRateLimiter
{
    public bool IsAvailable => true;
    public Task WaitUntilReadyAsync(CancellationToken cancelToken = default)
    {
        return Task.CompletedTask;
    }
}