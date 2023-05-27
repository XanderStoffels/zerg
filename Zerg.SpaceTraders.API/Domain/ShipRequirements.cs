namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// The requirements for installation on a ship.
/// </summary>
public class ShipRequirements
{
    /// <summary>
    /// The amount of power required from the reactor.
    /// </summary>
    public int Power { get; set; }
    
    /// <summary>
    /// The number of crew required for operation.
    /// </summary>
    public int Crew { get; set; }
    
    /// <summary>
    /// The number of module slots required for installation.
    /// </summary>
    public int Slots { get; set; }
}