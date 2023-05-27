namespace Zerg.SpaceTraders.API.Domain;

public class Faction
{
    /// <summary>
    /// See <see cref="FactionType"/>
    /// </summary>
    public required string Symbol { get; set; }
    
    public required string Name { get; set; }
    
    public required string Description { get; set; }
    
    public required string Headquarters { get; set; }
    
    /// <summary>
    /// Whether or not the faction is currently recruiting new agents.
    /// </summary>
    public required bool IsRecruiting { get; set; }
    
    public required List<FactionTrait> FactionTraits { get; set; }
}