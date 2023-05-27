namespace Zerg.SpaceTraders.API.Domain;

public class JumpGate
{
    /// <summary>
    /// The maximum jump range of the gate.
    /// </summary>
    public required int JumpRange { get; set; }
    
    /// <summary>
    /// The symbol of the faction that owns the gate.
    /// </summary>
    public required string FactionSymbol { get; set; }
    
    /// <summary>
    /// The systems within range of the gate that have a corresponding gate.
    /// </summary>
    public required List<ConnectedSystem> ConnectedSystems { get; set; } = new();
    
}