using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class NavigateShipResponse
{
    /// <summary>
    /// Details of the ship's fuel tanks including how much fuel was consumed during the last transit or action.
    /// </summary>
    public required  ShipFuel Fuel { get; set; }
    
    /// <summary>
    /// The navigation information of the ship.
    /// </summary>
    public required  ShipNav Nav { get; set; }
}