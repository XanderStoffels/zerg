namespace Zerg.SpaceTraders.API.Domain;

public class ShipCargoItem
{
    /// <summary>
    /// The unique identifier of the cargo item type.
    /// </summary>
    public required string Symbol { get; set; }

    /// <summary>
    /// The name of the cargo item type.
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// The description of the cargo item type.
    /// </summary>
    public required string Description { get; set; }
    
    /// <summary>
    /// The number of units of the cargo item.
    /// </summary>
    public required int Units { get; set; }
}