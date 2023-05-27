namespace Zerg.SpaceTraders.API.Domain;

public class TradeGood
{
    /// <summary>
    /// See <see cref="TradeSymbol"/>.
    /// </summary>
    public required string Symbol { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
}