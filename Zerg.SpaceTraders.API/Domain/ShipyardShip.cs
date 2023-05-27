namespace Zerg.SpaceTraders.API.Domain;

public class ShipyardShip
{
    /// <summary>
    /// See <see cref="ShipType"/>
    /// </summary>
    public required string Type { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    public required int PurchasePrice { get; set; }

    /// <summary>
    /// The frame of the ship. The frame determines the number of modules and mounting points of the ship, as well as base fuel capacity. As the condition of the frame takes more wear, the ship will become more sluggish and less maneuverable.
    /// </summary>
    public required ShipFrame Frame { get; set; }

    /// <summary>
    /// The reactor of the ship. The reactor is responsible for powering the ship's systems and weapons.
    /// </summary>
    public required ShipReactor Reactor { get; set; }

    /// <summary>
    /// The engine determines how quickly a ship travels between waypoints.
    /// </summary>
    public required ShipEngine ShipEngine { get; set; }

    public required List<ShipModule> Modules { get; set; } = new();

    public required List<ShipMount> Mounts { get; set; } = new();
}