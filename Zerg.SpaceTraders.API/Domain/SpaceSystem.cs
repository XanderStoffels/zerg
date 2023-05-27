namespace Zerg.SpaceTraders.API.Domain;

public class SpaceSystem
{
    public required string Symbol { get; set; }
    
    public required string SectorSymbol { get; set; }
    
    /// <summary>
    /// See <see cref="SystemType"/>
    /// </summary>
    public required string Type { get; set; }

    public required int X { get; set; }
    
    public required int Y { get; set; }

    public required List<Waypoint> Waypoints { get; set; } = new();

    public required List<Faction> Factions { get; set; } = new();
}