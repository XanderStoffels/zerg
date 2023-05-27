namespace Zerg.SpaceTraders.API.Domain;

public class MarketTransaction
{
    /// <summary>
    /// The symbol of the waypoint where the transaction took place.
    /// </summary>
    public required string WaypointSymbol { get; set; }
    
    /// <summary>
    /// The symbol of the ship that made the transaction.
    /// </summary>
    public required string ShipSymbol { get; set; }

    /// <summary>
    /// The symbol of the trade good. See <see cref="TradeSymbol"/>.
    /// </summary>
    public required string TradeSymbol { get; set; }

    /// <summary>
    /// The symbol of the trade good. See <see cref="MarketTransactionType"/>
    /// </summary>
    public required string Type { get; set; }
    
    /// <summary>
    /// The number of units of the transaction.
    /// </summary>
    public required int Units { get; set; }

    /// <summary>
    /// The price per unit of the transaction.
    /// </summary>
    public required int PricePerUnit { get; set; }

    /// <summary>
    /// The total price of the transaction.
    /// </summary>
    public required int TotalPrice { get; set; }

    /// <summary>
    /// The timestamp of the transaction.
    /// </summary>
    public required DateTime Timestamp { get; set; }
    
}