using Zerg.SpaceTraders.API.ApiResponses;

namespace Zerg.SpaceTraders.API.Services;

public interface IAgentService
{
    Task<MyAgentDetailsResponse> GetMyAgentDetailsAsync();
}