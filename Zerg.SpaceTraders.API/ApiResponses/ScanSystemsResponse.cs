using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class ScanSystemsResponse
{
    public required ShipNav Nav { get; set; }
    public required List<SpaceSystem> Systems { get; set; }
}