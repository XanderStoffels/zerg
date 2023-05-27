namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// The routing information for the ship's most recent transit or current location.
/// </summary>
public class ShipNavRoute
{
    /// <summary>
    /// The destination or departure of a ships nav route.
    /// </summary>
    public required ShipNavRouteWaypoint Destination { get; set; }
    
    /// <summary>
    /// The destination or departure of a ships nav route.
    /// </summary>
    public required ShipNavRouteWaypoint Departure { get; set; }

    /// <summary>
    /// The date time of the ship's departure.
    /// </summary>
    public required DateTime DepartureTime { get; set; }

    /// <summary>
    /// The date time of the ship's arrival. If the ship is in-transit, this is the expected time of arrival.
    /// </summary>
    public required DateTime Arrival { get; set; }
    
    
    
}