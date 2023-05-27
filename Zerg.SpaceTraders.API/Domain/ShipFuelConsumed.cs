namespace Zerg.SpaceTraders.API.Domain;

public class ShipFuelConsumed
{
    /// <summary>
    /// The amount of fuel consumed by the most recent transit or action.
    /// </summary>
    public required int Amount { get; set; }
    
    /// <summary>
    /// The time at which the fuel was consumed.
    /// </summary>
    public required DateTime Timestamp { get; set; }
}