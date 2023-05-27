namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// A surveyed deposit of a mineral or resource available for extraction
/// </summary>
public class SurveyDeposits
{
    /// <summary>
    /// The symbol of the deposit.
    /// See <see cref="TradeSymbol"/>
    /// </summary>
    public required string Symbol { get; set; }
}