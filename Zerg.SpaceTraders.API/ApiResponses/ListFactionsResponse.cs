using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class ListFactionsResponse
{
    public required List<Faction> Factions { get; set; } = new();
    public required Meta Meta { get; set; }
}