namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// The reactor of the ship. The reactor is responsible for powering the ship's systems and weapons.
/// </summary>
public class ShipReactor
{
    /// <summary>
    /// See <see cref="ShipReactorType"/>
    /// </summary>
    public required string Symbol { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    /// <summary>
    /// Condition is a range of 0 to 100 where 0 is completely worn out and 100 is brand new.
    /// </summary>
    public int Condition { get; set; }

    public required int PowerOutput { get; set; }

    /// <summary>
    /// The requirements for installation on a ship
    /// </summary>
    public required ShipRequirements Requirements { get; set; }
}