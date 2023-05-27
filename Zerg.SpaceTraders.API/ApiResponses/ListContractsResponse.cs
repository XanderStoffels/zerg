using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class ListContractsResponse
{
    public required List<Contract> Contracts { get; set; } = new();
    public required Meta Meta { get; set; }
}