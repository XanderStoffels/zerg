namespace Zerg.SpaceTraders.API.Domain;

public class ShipCargo
{
    /// <summary>
    /// The max number of items that can be stored in the cargo hold.
    /// </summary>
    public required int Capacity { get; set; }
    
    /// <summary>
    /// The number of items currently stored in the cargo hold.
    /// </summary>
    public required int Units { get; set; }
    
    /// <summary>
    /// The items currently in the cargo hold.
    /// </summary>
    public required List<ShipCargoItem> Inventory { get; set; } = new();
}