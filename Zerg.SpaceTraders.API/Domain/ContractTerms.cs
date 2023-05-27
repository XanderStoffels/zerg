namespace Zerg.SpaceTraders.API.Domain;

public class ContractTerms
{
    /// <summary>
    /// The deadline for the contract.
    /// </summary>
    public required DateTime Deadline { get; set; }
    
    public required ContractPayment ContractPayment { get; set; }
    
    public required List<ContractDeliveryGood> Deliver { get; set; } = new();
}