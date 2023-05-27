namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// A resource survey of a waypoint, detailing a specific extraction location and the types of resources that can be found there.
/// </summary>
public class Survey
{
    /// <summary>
    /// A unique signature for the location of this survey. This signature is verified when attempting an extraction using this survey.
    /// </summary>
    public required string Signature { get; set; }

    /// <summary>
    /// The symbol of the waypoint that this survey is for.
    /// </summary>
    public required string Symbol { get; set; }

    public required List<SurveyDeposits> Deposits { get; set; } = new();

    public required DateTime Expiration { get; set; }

    /// <summary>
    /// The size of the deposit. This value indicates how much can be extracted from the survey before it is exhausted.
    /// See <see cref="SurveyDepositSize"/>
    /// </summary>
    public required string Size { get; set; }
}