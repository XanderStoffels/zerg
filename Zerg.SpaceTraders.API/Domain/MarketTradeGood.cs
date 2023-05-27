namespace Zerg.SpaceTraders.API.Domain;

public class MarketTradeGood
{
    /// <summary>
    /// The symbol of the trade good.
    /// See <see cref="TradeSymbol"/>
    /// </summary>
    public required string Symbol { get; set; }
    
    /// <summary>
    /// The typical volume flowing through the market for this type of good. The larger the trade volume, the more stable prices will be.
    /// </summary>
    public required int TradeVolume { get; set; }
    
    /// <summary>
    /// A rough estimate of the total supply of this good in the marketplace.
    /// See <see cref="MarketTradeGoodSupply"/>
    /// </summary>
    public required string Supply { get; set; }
    
    /// <summary>
    /// The price at which this good can be purchased from the market.
    /// </summary>
    public required int PurchasePrice { get; set; }
    
    /// <summary>
    /// The price at which this good can be sold to the market.
    /// </summary>
    public required int SellPrice { get; set; }
}