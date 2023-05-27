namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// A mount is installed on the exterior of a ship.
/// </summary>
public class ShipMount
{
    /// <summary>
    /// See <see cref="ShipMountType"/>
    /// </summary>
    public required string Symbol { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }

    public int Strength { get; set; }

    /// <summary>
    /// See <see cref="ShipMountDeposits"/>
    /// </summary>
    public List<string> Deposits { get; set; } = new();

    /// <summary>
    /// The requirements for installation on a ship
    /// </summary>
    public required ShipRequirements Requirements { get; set; }
}