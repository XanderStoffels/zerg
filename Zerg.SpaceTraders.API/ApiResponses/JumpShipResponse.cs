using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class JumpShipResponse
{
    /// <summary>
    /// A cooldown is a period of time in which a ship cannot perform certain actions.
    /// </summary>
    public required Cooldown Cooldown { get; set; }
    
    /// <summary>
    /// The navigation information of the ship.
    /// </summary>
    public required ShipNav Nav { get; set; }
}