using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class ShipRefineResponse
{
    public required ShipCargo Cargo { get; set; }
    public required Cooldown Cooldown { get; set; }
    public required List<TradeGood> Produced { get; set; } = new();
    public required List<TradeGood> Consumed { get; set; } = new();
}