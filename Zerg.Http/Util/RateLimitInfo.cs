namespace Zerg.Http.Util;

/// <summary>
/// The SpaceTraders API will return the following headers in a 429 response to indicate the current rate limit status
/// </summary>
public class RateLimitInfo
{
    /// <summary>
    /// The type of rate limit that was exceeded.
    /// </summary>
    public required string Type { get; set; }
    /// <summary>
    /// The maximum number of requests that can be made in a given time period.
    /// </summary>
    public required int Limit { get; set; }
    /// <summary>
    /// The maximum number of requests that can be made in a given time period.
    /// </summary>
    public required int Remaining { get; set; }
    /// <summary>
    /// The time at which the current time period will reset.
    /// </summary>
    public required DateTime ResetsAt { get; set; }
    /// <summary>
    /// The maximum number of requests that can be made in a given burst duration.
    /// </summary>
    public required int BurstLimit { get; set; }
    /// <summary>
    /// The maximum number of requests that can be made in a given burst duration.
    /// </summary>
    public required int LimitPerSecond { get; set; }
}