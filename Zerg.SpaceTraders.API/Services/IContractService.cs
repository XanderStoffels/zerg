using Zerg.SpaceTraders.API.ApiResponses;
using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.Services;

public interface IContractService
{
    /// <summary>
    /// List all of your contracts.
    /// </summary>
    /// <param name="limit"></param>
    /// <param name="page"></param>
    /// <returns></returns>
    Task<ListContractsResponse> ListContractsAsync(int limit, int page);
    
    /// <summary>
    /// List all of your contracts.
    /// </summary>
    /// <returns></returns>
    Task<ListContractsResponse> ListContractsAsync();
    
    /// <summary>
    /// Get the details of a contract by ID.
    /// </summary>
    /// <param name="contractId"></param>
    /// <returns></returns>
    Task<GetContractResponse> GetContractAsync(string contractId);
    
    /// <summary>
    /// Accept a contract.
    /// </summary>
    /// <param name="contractId"></param>
    /// <returns></returns>
    Task<AcceptContractResponse> AcceptContractAsync(string contractId);
    
    /// <summary>
    /// Deliver cargo on a given contract.
    /// </summary>
    /// <param name="contractId">The ID of the contract</param>
    /// <param name="shipSymbol">The ship symbol of the ship delivering cargo</param>
    /// <param name="tradeSymbol">The goods you are delivering. See <see cref="TradeSymbol"/></param>
    /// <param name="units">The amount of goods</param>
    /// <returns></returns>
    Task<DeliverContractResponse> DeliverContractAsync(string contractId, string shipSymbol, string tradeSymbol, int units);
    
    /// <summary>
    /// Fulfill a contract
    /// </summary>
    /// <param name="contractId"></param>
    /// <returns></returns>
    Task<FulfillContractResponse> FulfillContractAsync(string contractId);
}