using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.Util;

public static class Formulae
{
    /// <summary>
    /// Calculate the navigation time for a given distance.
    /// </summary>
    /// <param name="distance"></param>
    /// <param name="speed"></param>
    /// <param name="shipNavFlightMode">See <see cref="ShipNavFlightMode"/></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static TimeSpan NavigationTime(double distance, double speed, string shipNavFlightMode)
    {
        return shipNavFlightMode switch
        {
            ShipNavFlightMode.Drift => TimeSpan.FromSeconds(15 + 100 * (distance / speed)),
            ShipNavFlightMode.Stealth => TimeSpan.FromSeconds(15 + 20 * (distance / speed)),
            ShipNavFlightMode.Cruise => TimeSpan.FromSeconds(15 + 10 * (distance / speed)),
            ShipNavFlightMode.Burn => TimeSpan.FromSeconds(15 + 5 * (distance / speed)),
            _ => throw new ArgumentOutOfRangeException(nameof(shipNavFlightMode), shipNavFlightMode,
                "Given flight mode is not supported.")
        };
    }

    /// <summary>
    /// Calculate the fuel consumption for a given distance.
    /// </summary>
    /// <param name="distance"></param>
    /// <param name="shipNavFlightMode">See <see cref="ShipNavFlightMode"/></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static double FuelConsumption(double distance, string shipNavFlightMode)
    {
        return shipNavFlightMode switch
        {
            ShipNavFlightMode.Drift => 1,
            ShipNavFlightMode.Stealth => distance,
            ShipNavFlightMode.Cruise => distance,
            ShipNavFlightMode.Burn => distance * 2,
            _ => throw new ArgumentOutOfRangeException(nameof(shipNavFlightMode), shipNavFlightMode, null)
        };
    }

}