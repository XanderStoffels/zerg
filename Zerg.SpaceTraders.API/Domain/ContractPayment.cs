namespace Zerg.SpaceTraders.API.Domain;

public class ContractPayment
{
    /// <summary>
    /// The amount of credits received up front for accepting the contract.
    /// </summary>
    public required int OnAccepted { get; set; }
    
    /// <summary>
    /// The amount of credits received when the contract is fulfilled.
    /// </summary>
    public required int OnFulfilled { get; set; }
}