using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class ScanShipsResponse
{
    public required Cooldown Cooldown { get; set; }
    public required List<Ship> Ships { get; set; } = new();
}