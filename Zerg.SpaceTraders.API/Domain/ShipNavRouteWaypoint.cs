namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// The destination or departure of a ships nav route.
/// </summary>
public class ShipNavRouteWaypoint
{
    public required string Symbol { get; set; }
    
    /// <summary>
    /// The type of waypoint.
    /// See <see cref="WaypointType"/>
    /// </summary>
    public required string Type { get; set; }

    public required string SystemSymbol { get; set; }

    public required int X { get; set; }

    public required int Y { get; set; }
}