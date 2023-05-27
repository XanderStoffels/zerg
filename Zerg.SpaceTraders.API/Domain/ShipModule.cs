namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// A module can be installed in a ship and provides a set of capabilities such as storage space or quarters for crew. Module installations are permanent.
/// </summary>
public class ShipModule
{
    /// <summary>
    /// See <see cref="ShipModuleType"/>
    /// </summary>
    public required string Symbol { get; set; }

    public int Capacity { get; set; }

    public int Range { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }

    /// <summary>
    /// The requirements for installation on a ship
    /// </summary>
    public required ShipRequirements Requirements { get; set; }
}