using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class WarpShipResponse
{
    public required ShipFuel Fuel { get; set; }
    public required ShipNav Nav { get; set; }
}