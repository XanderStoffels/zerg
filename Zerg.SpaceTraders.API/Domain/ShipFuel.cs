namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// Details of the ship's fuel tanks including how much fuel was consumed during the last transit or action.
/// </summary>
public class ShipFuel
{
    /// <summary>
    /// The current amount of fuel in the ship's tanks.
    /// </summary>
    public required int Current { get; set; }
    
    /// <summary>
    /// The maximum amount of fuel the ship's tanks can hold.
    /// </summary>
    public required int Capacity { get; set; }

    /// <summary>
    /// The amount of fuel consumed by the most recent transit or action.
    /// </summary>
    public ShipFuelConsumed? Consumed { get; set; }
}