using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class ExtractResourcesResponse
{
    /// <summary>
    /// A cooldown is a period of time in which a ship cannot perform certain actions.
    /// </summary>
    public required Cooldown Cooldown { get; set; }
    public required Extraction Extraction { get; set; }
    public required ShipCargo Cargo { get; set; }
}