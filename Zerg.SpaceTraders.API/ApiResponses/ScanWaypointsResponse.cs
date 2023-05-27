using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class ScanWaypointsResponse
{
    public required Cooldown Cooldown { get; set; }
    public required List<Waypoint> Waypoints { get; set; } = new();
}