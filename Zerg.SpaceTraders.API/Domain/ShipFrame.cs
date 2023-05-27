namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// The frame of the ship. The frame determines the number of modules and mounting points of the ship, as well as base fuel capacity. As the condition of the frame takes more wear, the ship will become more sluggish and less maneuverable.
/// </summary>
public class ShipFrame
{
    /// <summary>
    /// See <see cref="ShipFrameType"/>
    /// </summary>
    public required string Symbol { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    /// <summary>
    /// Condition is a range of 0 to 100 where 0 is completely worn out and 100 is brand new.
    /// </summary>
    public int Condition { get; set; }

    public required int ModuleSlots { get; set; }

    public required int MountingPoints { get; set; }

    public required int FuelCapacity { get; set; }

    public required ShipRequirements Requirements { get; set; }
}