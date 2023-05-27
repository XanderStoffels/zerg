using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class CreateChartResponse
{
    public required Chart Chart { get; set; }
    public required Waypoint Waypoint { get; set; }
}