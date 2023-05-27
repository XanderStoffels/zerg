namespace Zerg.SpaceTraders.API.Domain;

public class Agent
{
    public required string AccountId { get; set; }
    
    public required string Symbol { get; set; }
    /// <summary>
    /// The headquarters of the agent.
    /// </summary>
    public required string Headquarters { get; set; }
    
    /// <summary>
    /// The number of credits the agent has available. Credits can be negative if funds have been overdrawn.
    /// </summary>
    public int Credits { get; set; }
    
    /// <summary>
    /// The faction the agent started with.
    /// </summary>
    public required string StartingFaction { get; set; }
}