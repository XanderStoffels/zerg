namespace Zerg.SpaceTraders.API.Domain;

/// <summary>
/// A waypoint is a location that ships can travel to such as a Planet, Moon or Space Station.
/// </summary>
public class Waypoint
{
    public required string Symbol { get; set; }
    
    /// <summary>
    /// The type of waypoint.
    /// See <see cref="WaypointTrait"/>
    /// </summary>
    public required string Type { get; set; }

    public required string SystemSymbol { get; set; }

    public required int X { get; set; }
    public required int Y { get; set; }

    /// <summary>
    /// An orbital is another waypoint that orbits a parent waypoint.
    /// </summary>
    public required List<WaypointOrbital> Oribitals { get; set; } = new();
    
    public required List<WaypointTrait> Traits { get; set; } = new();

    public WaypointFaction? Faction { get; set; }
    
    /// <summary>
    /// The chart of a system or waypoint, which makes the location visible to other agents.
    /// </summary>
    public WaypointChart? Chart { get; set; }
}