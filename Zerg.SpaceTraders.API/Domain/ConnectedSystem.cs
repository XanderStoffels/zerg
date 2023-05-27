namespace Zerg.SpaceTraders.API.Domain;

public class ConnectedSystem
{
    public required string Symbol { get; set; }
    
    public required string SectorSymbol { get; set; }
    
    /// <summary>
    /// The type of waypoint.
    /// </summary>
    public required string Type { get; set; }
    
    /// <summary>
    /// The symbol of the faction that owns the connected jump gate in the system.
    /// </summary>
    public string? FactionSymbol { get; set; }
    
    public required int X { get; set; }
    
    public required int Y { get; set; }
    
    public required int Distance { get; set; }
}