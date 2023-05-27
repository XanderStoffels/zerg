using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class RefuelShipResponse
{
    public required Agent Agent { get; set; }
    public required ShipFuel Fuel { get; set; }
    public required MarketTransaction Transaction { get; set; }
}