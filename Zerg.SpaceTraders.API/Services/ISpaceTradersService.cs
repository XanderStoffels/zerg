using Zerg.SpaceTraders.API.ApiResponses;
using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.Services;

public interface ISpaceTradersService
{
    /// <summary>
    /// Return the status of the game server.
    /// </summary>
    /// <returns></returns>
    Task<ServerStatusResponse> GetStatusAsync();

    /// <summary>
    /// Creates a new agent and ties it to a temporary Account.
    /// A new agent will be granted an authorization token, a contract with their starting faction, a command ship with a jump drive, and one hundred thousand credits.
    /// </summary>
    /// <param name="factionName">Use one of the factions found in <see cref="FactionType"/></param>
    /// <param name="symbol">The agent symbol is a 3-14 character string that will represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.</param>
    /// <param name="email"></param>
    /// <returns></returns>
    Task<RegisterAgentResponse> RegisterAgentAsync(string factionName, string symbol, string email);
}