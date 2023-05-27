namespace Zerg.SpaceTraders.API.Domain;

public class Shipyard
{
    /// <summary>
    /// The symbol of the shipyard. The symbol is the same as the waypoint where the shipyard is located.
    /// </summary>
    public required string Symbol { get; set; }

    /// <summary>
    /// The list of ship types available for purchase at this shipyard.
    /// See <see cref="ShipType"/>
    /// </summary>
    public required List<string> ShipTypes { get; set; }

    /// <summary>
    /// The list of recent transactions at this shipyard.
    /// </summary>
    public List<ShipyardTransaction> Transactions { get; set; } = new();

    /// <summary>
    /// The ships that are currently available for purchase at the shipyard.
    /// </summary>
    public List<ShipyardShip> Ships { get; set; } = new();
    
}