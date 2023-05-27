using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class GetFactionResponse
{
    public required Faction Faction { get; set; }
}