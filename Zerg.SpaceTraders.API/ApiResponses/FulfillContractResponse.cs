using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class FulfillContractResponse
{
    public required Agent Agent { get; set; }
    public required Contract Contract { get; set; }
}