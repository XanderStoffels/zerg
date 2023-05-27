using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class AcceptContractResponse
{
    public required Agent Agent { get; set; }
    public required Contract Contract { get; set; }
}