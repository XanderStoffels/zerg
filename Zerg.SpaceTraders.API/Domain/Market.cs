namespace Zerg.SpaceTraders.API.Domain;

public class Market
{
    /// <summary>
    /// The symbol of the market. The symbol is the same as the waypoint where the market is located.
    /// </summary>
    public required string Symbol { get; set; }
    
    /// <summary>
    /// The list of goods that are exported from this market.
    /// </summary>
    public required List<TradeGood> Exports { get; set; } = new();

    /// <summary>
    /// The list of goods that are sought as imports in this market.
    /// </summary>
    public required List<TradeGood> Imports { get; set; } = new();

    /// <summary>
    /// The list of goods that are bought and sold between agents at this market.
    /// </summary>
    public required List<TradeGood> Exchange { get; set; } = new();

    /// <summary>
    /// The list of recent transactions at this market. Visible only when a ship is present at the market.
    /// </summary>
    public required List<MarketTransaction> Transactions { get; set; } = new();

    /// <summary>
    /// The list of goods that are traded at this market. Visible only when a ship is present at the market.
    /// </summary>
    public required List<MarketTradeGood> TradeGoods { get; set; } = new();
}