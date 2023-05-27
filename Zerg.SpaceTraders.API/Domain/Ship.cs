namespace Zerg.SpaceTraders.API.Domain;

public class Ship
{
    /// <summary>
    /// The globally unique identifier of the ship in the following format:
    /// [AGENT_SYMBOL]_[HEX_ID]
    /// </summary>
    public required string Symbol { get; set; }
    
    /// <summary>
    /// The public registration information of the ship
    /// </summary>
    public required ShipRegistration Registration { get; set; }
    
    /// <summary>
    /// The navigation information of the ship.
    /// </summary>
    public required ShipNav Nav { get; set; }
    
    /// <summary>
    /// The ship's crew service and maintain the ship's systems and equipment.
    /// </summary>
    public required ShipCrew Crew { get; set; }
    
    /// <summary>
    /// The frame of the ship. The frame determines the number of modules and mounting points of the ship, as well as base fuel capacity. As the condition of the frame takes more wear, the ship will become more sluggish and less maneuverable.
    /// </summary>
    public required ShipFrame Frame { get; set; }
    
    /// <summary>
    /// The reactor of the ship. The reactor is responsible for powering the ship's systems and weapons
    /// </summary>
    public required ShipReactor Reactor { get; set; }
    
    /// <summary>
    /// The engine determines how quickly a ship travels between waypoints.
    /// </summary>
    public required ShipEngine Engine { get; set; }
    
    public required List<ShipModule> Modules { get; set; } = new();
    
    public required List<ShipMount> Mounts { get; set; } = new();
    
    public required ShipCargo Cargo { get; set; }

    /// <summary>
    /// Details of the ship's fuel tanks including how much fuel was consumed during the last transit or action.
    /// </summary>
    public required ShipFuel Fuel { get; set; }
}