namespace Zerg.SpaceTraders.API.Domain;

public class Contract
{
    public required string Id { get; set; }
    
    /// <summary>
    /// The symbol of the faction that this contract is for.
    /// </summary>
    public required string FactionSymbol { get; set; }
    
    public required string Type { get; set; }
    
    public required ContractTerms Terms { get; set; }
    
    /// <summary>
    /// Whether the contract has been accepted by the agent
    /// </summary>
    public required bool Accepted { get; set; }
    
    /// <summary>
    /// Whether the contract has been fulfilled
    /// </summary>
    public required bool Fulfilled { get; set; }
    
    /// <summary>
    /// The time at which the contract is no longer available to be accepted
    /// </summary>
    public required DateTime DeadlineToAccept { get; set; }
}