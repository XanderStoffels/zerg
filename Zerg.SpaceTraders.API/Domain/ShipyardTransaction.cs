namespace Zerg.SpaceTraders.API.Domain;

public class ShipyardTransaction
{
    /// <summary>
    /// The symbol of the waypoint where the transaction took place.
    /// </summary>
    public required string WaypointSymbol { get; set; }

    /// <summary>
    /// The symbol of the ship that was purchased.
    /// </summary>
    public required string ShipSymbol { get; set; }

    /// <summary>
    /// The price of the transaction.
    /// </summary>
    public required int Price { get; set; }

    /// <summary>
    /// The symbol of the agent that made the transaction.
    /// </summary>
    public required string AgentSymbol { get; set; }

    /// <summary>
    /// The timestamp of the transaction.
    /// </summary>
    public required DateTime Timestamp { get; set; }
}