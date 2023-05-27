namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// A cooldown is a period of time in which a ship cannot perform certain actions.
/// </summary>
public class Cooldown
{
    /// <summary>
    /// The symbol of the ship that is on cooldown
    /// </summary>
    public required string ShipSymbol { get; set; }
    
    /// <summary>
    /// The total duration of the cooldown in seconds
    /// </summary>
    public required int TotalSeconds { get; set; }
    
    /// <summary>
    /// The total duration of the cooldown in seconds
    /// </summary>
    public required int RemainingSeconds { get; set; }
    
    /// <summary>
    /// The date and time when the cooldown expires in ISO 8601 format
    /// </summary>
    public DateTime? Expiration { get; set; }
}