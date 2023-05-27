namespace Zerg.SpaceTraders.API.Domain;

public class ContractDeliveryGood
{
    /// <summary>
    /// The symbol of the trade good to deliver.
    /// </summary>
    public required string TradeSymbol { get; set; }
    
    /// <summary>
    /// The destination where goods need to be delivered.
    /// </summary>
    public required string DestinationSymbol { get; set; }
    
    /// <summary>
    /// The number of units that need to be delivered on this contract.
    /// </summary>
    public required int UnitsRequired { get; set; }
    
    /// <summary>
    /// The number of units fulfilled on this contract.
    /// </summary>
    public required int UnitsFulfilled { get; set; }
    
}