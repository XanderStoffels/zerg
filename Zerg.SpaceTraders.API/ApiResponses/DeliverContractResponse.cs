using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class DeliverContractResponse
{
    public required Contract Contract { get; set; }
    public required ShipCargo Cargo { get; set; }
}