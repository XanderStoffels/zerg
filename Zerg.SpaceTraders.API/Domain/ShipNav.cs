namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// The navigation information of the ship.
/// </summary>
public class ShipNav
{
    /// <summary>
    /// The system symbol of the ship's current location.
    /// </summary>
    public required string SystemSymbol { get; set; }

    /// <summary>
    /// The waypoint symbol of the ship's current location, or if the ship is in-transit, the waypoint symbol of the ship's destination.
    /// </summary>
    public required string WaypointSymbol { get; set; }

    /// <summary>
    /// The routing information for the ship's most recent transit or current location.
    /// </summary>
    public required ShipNavRoute Route { get; set; }

    /// <summary>
    /// The current status of the ship.
    /// See <see cref="ShipNavStatus"/>
    /// </summary>
    public required string Status { get; set; }

    /// <summary>
    /// The ship's set speed when traveling between waypoints or systems.
    /// <see cref="ShipNavFlightModeStrings"/>
    /// </summary>
    public required string FlightMode { get; set; }
    
}