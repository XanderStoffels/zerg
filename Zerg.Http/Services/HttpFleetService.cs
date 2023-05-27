using RestSharp;
using RestSharp.Authenticators;
using Zerg.Http.Util;
using Zerg.SpaceTraders.API.ApiResponses;
using Zerg.SpaceTraders.API.Domain;
using Zerg.SpaceTraders.API.RateLimiting;
using Zerg.SpaceTraders.API.Services;

namespace Zerg.Http.Services;

public class HttpFleetService :  IFleetService
{
    private readonly RestClient _client;
    private readonly IRateLimiter _limiter;

    public HttpFleetService(string url, string token, IRateLimiter limiter)
    {
        var authenticator = new JwtAuthenticator(token);
        var options = new RestClientOptions(url)
        {
            Authenticator = authenticator
        };
        
        _client = new(options);
        _client.AddDefaultHeader("Accept", "application/json");
        _limiter = limiter;
    }

    public async Task<ListShipsResponse> ListShipsAsync(int limit, int page)
    {
        if (limit > 20) limit = 20;
        if (limit < 1) limit = 1;
        if (page < 1) page = 1;
        
        var request = new RestRequest("my/ships")
            .AddQueryParameter("limit", limit)
            .AddQueryParameter("page", page);

        await _limiter.WaitUntilReadyAsync();
        var response = await _client.ExecuteGetAsync(request);
        return response.UnpackWithResponse<ListShipsResponse>();
    }
    
    public async IAsyncEnumerable<Ship> ListAllShipsAsync()
    {
        var page = 1;
        var received = 0;
        
        var initialRequest = await ListShipsAsync(20, page++);
        foreach (var ship in initialRequest.Data)
        {
            yield return ship;
            received++;
        }
        
        var total = initialRequest.Meta.Total;
        while (received < total)
        {
            var response = await ListShipsAsync(20, page++);
            foreach (var ship in response.Data)
            {
                yield return ship;
                received++;
            }
        }
    }

    public Task<PurchaseShipResponse> PurchaseShipAsync(string shipType, string waypointSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<Ship> GetShipAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<ShipCargo> GetShipCargoAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<ShipNav> OrbitShipAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<ShipRefineResponse> ShipRefine(string shipSymbol, string produce)
    {
        throw new NotImplementedException();
    }

    public Task<CreateChartResponse> CreateChartAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<Cooldown> GetShipCooldownAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<ShipNav> DockShipAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<CreateSurveyResponse> CreateSurveyAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<ExtractResourcesResponse> ExtractResourcesAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<ShipCargo> JettisonCargoAsync(string shipSymbol, string tradeSymbol, int units)
    {
        throw new NotImplementedException();
    }

    public Task<JumpShipResponse> JumpShipAsync(string shipSymbol, string systemSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<NavigateShipResponse> NavigateShipAsync(string shipSymbol, string waypointSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<ShipNav> PatchShipNavAsync(string shipSymbol, string flightMode)
    {
        throw new NotImplementedException();
    }

    public Task<ShipNav> GetShipNavAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<WarpShipResponse> WarpShipAsync(string shipSymbol, string waypointSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<SellCargoResponse> SellCargoAsync(string shipSymbol, string tradeSymbol, int units)
    {
        throw new NotImplementedException();
    }

    public Task<ScanSystemsResponse> ScanSystemsAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<ScanWaypointsResponse> ScanWaypointsAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<ScanShipsResponse> ScanShipsAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<RefuelShipResponse> RefuelShipAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }

    public Task<PurchaseCargoResponse> PurchaseCargoAsync(string shipSymbol, string tradeSymbol, int units)
    {
        throw new NotImplementedException();
    }

    public Task<ShipCargo> TransferCargoAsync(string fromShipSymbol, string toShipSymbol, string tradeSymbol, int units)
    {
        throw new NotImplementedException();
    }

    public Task<Contract> NegotiateContractAsync(string shipSymbol)
    {
        throw new NotImplementedException();
    }
    
}