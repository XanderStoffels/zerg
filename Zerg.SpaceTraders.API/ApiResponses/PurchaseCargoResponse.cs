using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class PurchaseCargoResponse
{
    public required Agent Agent { get; set; }
    public required ShipCargo Cargo { get; set; }
    public required MarketTransaction Transaction { get; set; }
}