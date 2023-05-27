using Zerg.SpaceTraders.API.ApiResponses;
using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.Services;

public interface IFleetService
{
    /// <summary>
    /// Retrieve all of your ships.
    /// </summary>
    /// <param name="limit">How many entries to return per page, between 1 and 20</param>
    /// <param name="page">What entry offset to request, at least 1</param>
    /// <returns></returns>
    Task<ListShipsResponse> ListShipsAsync(int limit, int page);
    
    /// <summary>
    /// Retrieve all of your ships.
    /// </summary>
    /// <returns></returns>
    IAsyncEnumerable<Ship> ListAllShipsAsync();

    /// <summary>
    /// Purchase a ship.
    /// </summary>
    /// <param name="shipType">See <see cref="ShipType"/></param>
    /// <param name="waypointSymbol">The symbol of the waypoint you want to purchase the ship at.</param>
    /// <returns></returns>
    Task<PurchaseShipResponse> PurchaseShipAsync(string shipType, string waypointSymbol);
    
    /// <summary>
    /// Retrieve the details of your ship.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <returns></returns>
    Task<Ship> GetShipAsync(string shipSymbol);
    
    /// <summary>
    /// Retrieve the cargo of your ship.
    /// </summary>
    /// <param name="shipSymbol">The symbol of the ship</param>
    /// <returns></returns>
    Task<ShipCargo> GetShipCargoAsync(string shipSymbol);

    /// <summary>
    /// Attempt to move your ship into orbit at it's current location. The request will only succeed if your ship is capable of moving into orbit at the time of the request.
    /// </summary>
    /// <param name="shipSymbol">The symbol of the ship</param>
    /// <returns></returns>
    Task<ShipNav> OrbitShipAsync(string shipSymbol);
    
    /// <summary>
    /// Attempt to refine the raw materials on your ship. The request will only succeed if your ship is capable of refining at the time of the request.
    /// </summary>
    /// <param name="shipSymbol">The symbol of the ship</param>
    /// <param name="produce">The product to produce. See <see cref="ShipRefineProduct"/></param>
    /// <returns></returns>
    Task<ShipRefineResponse> ShipRefine(string shipSymbol, string produce);
    
    /// <summary>
    /// Command a ship to chart the current waypoint.
    /// Waypoints in the universe are uncharted by default. These locations will not show up in the API until they have been charted by a ship.
    /// Charting a location will record your agent as the one who created the chart.
    /// </summary>
    /// <param name="shipSymbol">The symbol of the ship</param>
    /// <returns></returns>
    Task<CreateChartResponse> CreateChartAsync(string shipSymbol);
    
    /// <summary>
    /// Retrieve the details of your ship's reactor cooldown. Some actions such as activating your jump drive, scanning, or extracting resources taxes your reactor and results in a cooldown.
    /// Your ship cannot perform additional actions until your cooldown has expired. The duration of your cooldown is relative to the power consumption of the related modules or mounts for the action taken.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <returns></returns>
    Task<Cooldown> GetShipCooldownAsync(string shipSymbol);
    
    /// <summary>
    /// Attempt to dock your ship at it's current location. Docking will only succeed if the waypoint is a dockable location, and your ship is capable of docking at the time of the request.
    /// </summary>
    /// <param name="shipSymbol">The symbol of the ship</param>
    /// <returns></returns>
    Task<ShipNav> DockShipAsync(string shipSymbol);
    
    /// <summary>
    /// If you want to target specific yields for an extraction, you can survey a waypoint, such as an asteroid field, and send the survey in the body of the extract request. Each survey may have multiple deposits, and if a symbol shows up more than once, that indicates a higher chance of extracting that resource.
    /// Your ship will enter a cooldown between consecutive survey requests. Surveys will eventually expire after a period of time. Multiple ships can use the same survey for extraction.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <returns></returns>
    Task<CreateSurveyResponse> CreateSurveyAsync(string shipSymbol);
    
    /// <summary>
    /// Extract resources from the waypoint into your ship. Send an optional survey as the payload to target specific yields.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <returns></returns>
    Task<ExtractResourcesResponse> ExtractResourcesAsync(string shipSymbol);
    
    /// <summary>
    /// Jettison cargo from your ship's cargo hold.
    /// </summary>
    /// <param name="shipSymbol">Your ship's symbol</param>
    /// <param name="tradeSymbol">See <see cref="TradeSymbol"/></param>
    /// <param name="units">Amount of units to jettison.</param>
    /// <returns></returns>
    Task<ShipCargo> JettisonCargoAsync(string shipSymbol, string tradeSymbol, int units);
    
    /// <summary>
    /// Jump your ship instantly to a target system. When used while in orbit or docked to a jump gate waypoint, any ship can use this command. When used elsewhere, jumping requires a jump drive unit and consumes a unit of antimatter (which needs to be in your cargo).
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <param name="systemSymbol">The system symbol to jump to.</param>
    /// <returns></returns>
    Task<JumpShipResponse> JumpShipAsync(string shipSymbol, string systemSymbol);
    
    /// <summary>
    /// Navigate to a target destination. The destination must be located within the same system as the ship. Navigating will consume the necessary fuel and supplies from the ship's manifest, and will pay out crew wages from the agent's account.
    /// The returned response will detail the route information including the expected time of arrival. Most ship actions are unavailable until the ship has arrived at it's destination.
    /// To travel between systems, see <see cref="WarpShipAsync"/> or <see cref="JumpShipAsync"/> actions.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <param name="waypointSymbol"></param>
    /// <returns></returns>
    Task<NavigateShipResponse> NavigateShipAsync(string shipSymbol, string waypointSymbol);
    
    /// <summary>
    /// Update the nav data of a ship, such as the flight mode.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <param name="flightMode">The ship's set speed when traveling between waypoints or systems. See <see cref="ShipNavFlightModeStrings"/></param>
    /// <returns></returns>
    Task<ShipNav> PatchShipNavAsync(string shipSymbol, string flightMode);
    
    /// <summary>
    /// Get the current nav status of a ship.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <returns></returns>
    Task<ShipNav> GetShipNavAsync(string shipSymbol);
    
    /// <summary>
    /// Warp your ship to a target destination in another system. Warping will consume the necessary fuel and supplies from the ship's manifest, and will pay out crew wages from the agent's account.
    /// The returned response will detail the route information including the expected time of arrival. Most ship actions are unavailable until the ship has arrived at it's destination.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <param name="waypointSymbol">The target destination.</param>
    /// <returns></returns>
    Task<WarpShipResponse> WarpShipAsync(string shipSymbol, string waypointSymbol);
    
    /// <summary>
    /// Sell cargo.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <param name="tradeSymbol">See <see cref="TradeSymbol"/></param>
    /// <param name="units"></param>
    /// <returns></returns>
    Task<SellCargoResponse> SellCargoAsync(string shipSymbol, string tradeSymbol, int units);
    

    /// <summary>
    /// Activate your ship's sensor arrays to scan for system information.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <returns></returns>
    Task<ScanSystemsResponse> ScanSystemsAsync(string shipSymbol);
    
    /// <summary>
    /// Activate your ship's sensor arrays to scan for waypoint information.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <returns></returns>
    Task<ScanWaypointsResponse> ScanWaypointsAsync(string shipSymbol);
    
    /// <summary>
    /// Activate your ship's sensor arrays to scan for ship information.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <returns></returns>
    Task<ScanShipsResponse> ScanShipsAsync(string shipSymbol);
    
    /// <summary>
    /// Refuel your ship from the local market.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <returns></returns>
    Task<RefuelShipResponse> RefuelShipAsync(string shipSymbol);
    
    /// <summary>
    /// Purchase cargo.
    /// </summary>
    /// <param name="shipSymbol"></param>
    /// <param name="tradeSymbol">See <see cref="TradeSymbol"/></param>
    /// <param name="units"></param>
    /// <returns></returns>
    Task<PurchaseCargoResponse> PurchaseCargoAsync(string shipSymbol, string tradeSymbol, int units);
    
    /// <summary>
    /// Transfer cargo between ships.
    /// </summary>
    /// <param name="fromShipSymbol"></param>
    /// <param name="toShipSymbol"></param>
    /// <param name="tradeSymbol">See <see cref="TradeSymbol"/></param>
    /// <param name="units"></param>
    /// <returns></returns>
    Task<ShipCargo> TransferCargoAsync(string fromShipSymbol, string toShipSymbol, string tradeSymbol, int units);
    
    /// <summary>
    /// </summary>
    /// <remarks>Currently work in progress.</remarks>
    /// <param name="shipSymbol"></param>
    /// <returns></returns>
    Task<Contract> NegotiateContractAsync(string shipSymbol);
}