using Zerg.SpaceTraders.API.ApiResponses;

namespace Zerg.SpaceTraders.API.Services;

public interface IFactionService
{
    /// <summary>
    /// List all discovered factions in the game.
    /// </summary>
    /// <param name="limit">How many entries to return per page, between 1 and 20</param>
    /// <param name="page">What entry offset to request, >=1</param>
    /// <returns></returns>
    Task<ListFactionsResponse> GetFactionsAsync(int limit, int page);
    
    /// <summary>
    /// List all discovered factions in the game.
    /// </summary>
    /// <returns></returns>
    Task<ListFactionsResponse> GetFactionsAsync();

    /// <summary>
    /// View the details of a faction.
    /// </summary>
    /// <param name="factionSymbol">The faction symbol.</param>
    /// <returns></returns>
    Task<GetFactionResponse> GetFactionAsync(string factionSymbol);
}