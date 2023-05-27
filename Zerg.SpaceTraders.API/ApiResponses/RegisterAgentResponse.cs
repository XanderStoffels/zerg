using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class RegisterAgentResponse
{
    public required Agent Agent { get; set; }
    
    public required Contract Contract { get; set; }
    
    public required Faction Faction { get; set; }
    
    /// <summary>
    /// A ship.
    /// </summary>
    public required Ship Ship { get; set; }
    
    /// <summary>
    /// A Bearer token for accessing secured API endpoints.
    /// </summary>
    public required string Token { get; set; }
}