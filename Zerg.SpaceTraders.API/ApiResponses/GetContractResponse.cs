using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class GetContractResponse
{
    public required Contract Contract { get; set; }
    public required Meta Meta { get; set; }
}