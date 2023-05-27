namespace Zerg.SpaceTraders.API.Domain;

public class ShipRegistration
{
    public required string Name { get; set; }
    
    /// <summary>
    /// The symbol of the faction the ship is registered with
    /// </summary>
    public required string FactionSymbol { get; set; }
    
    /// <summary>
    /// The registered role of the ship
    /// See <see cref="ShipRole"/>
    /// </summary>
    public required string Role { get; set; }
}