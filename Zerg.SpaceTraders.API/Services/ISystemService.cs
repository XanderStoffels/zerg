using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.Services;

public interface ISystemService
{
    /// <summary>
    /// Return a list of all systems.
    /// </summary>
    /// <param name="limit">How many entries to return per page, between 1 and 20</param>
    /// <param name="page">What entry offset to request, min 1</param>
    /// <returns></returns>
    Task<List<SpaceSystem>> ListSystemsAsync(int limit, int page);
    
    /// <summary>
    /// Return a list of all systems.
    /// </summary>
    /// <returns></returns>
    Task<List<SpaceSystem>> ListSystemsAsync();
    
    /// <summary>
    /// Get the details of a system.
    /// </summary>
    /// <param name="systemSymbol">The system symbol</param>
    /// <returns></returns>
    Task<SpaceSystem> GetSystemAsync(string systemSymbol);
    
    /// <summary>
    /// Fetch all of the waypoints for a given system. SpaceSystem must be charted or a ship must be present to return waypoint details.
    /// </summary>
    /// <param name="systemSymbol"></param>
    /// <returns></returns>
    Task<List<Waypoint>> ListWaypointsAsync(string systemSymbol);

    /// <summary>
    /// Fetch all of the waypoints for a given system. SpaceSystem must be charted or a ship must be present to return waypoint details.
    /// </summary>
    /// <param name="systemSymbol"></param>
    /// <param name="limit">How many entries to return per page, between 1 and 20</param>
    /// <param name="page">What entry offset to request, at least 1</param>
    /// <returns></returns>
    Task<List<Waypoint>> ListWaypointsAsync(string systemSymbol, int limit, int page);
    
    /// <summary>
    /// View the details of a waypoint.
    /// </summary>
    /// <param name="systemSymbol">The system symbol</param>
    /// <param name="waypointSymbol">The waypoint symbol</param>
    /// <returns></returns>
    Task<Waypoint> GetWaypointAsync(string systemSymbol, string waypointSymbol);
    
    /// <summary>
    /// Retrieve imports, exports and exchange data from a marketplace. Imports can be sold, exports can be purchased, and exchange goods can be purchased or sold. Send a ship to the waypoint to access trade good prices and recent transactions.
    /// </summary>
    /// <param name="systemSymbol">The system symbol</param>
    /// <param name="waypointSymbol">The waypoint symbol</param>
    /// <returns></returns>
    Task<Market> GetMarketAsync(string systemSymbol, string waypointSymbol);

    /// <summary>
    /// Get the shipyard for a waypoint. Send a ship to the waypoint to access ships that are currently available for purchase and recent transactions.
    /// </summary>
    /// <param name="systemSymbol">The system symbol</param>
    /// <param name="waypointSymbol">The waypoint symbol</param>
    /// <returns></returns>
    Task<Shipyard> GetShipyardAsync(string systemSymbol, string waypointSymbol);
    
    /// <summary>
    /// Get jump gate details for a waypoint.
    /// </summary>
    /// <param name="systemSymbol">The system symbol</param>
    /// <param name="waypointSymbol">The waypoint symbol</param>
    /// <returns></returns>
    Task<JumpGate> GetJumpGateAsync(string systemSymbol, string waypointSymbol);
}