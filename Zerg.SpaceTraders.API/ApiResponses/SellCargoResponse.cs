using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class SellCargoResponse
{
    public required Agent Agent { get; set; }
    public required ShipCargo Cargo { get; set; }
    public required MarketTransaction Transaction { get; set; }
}