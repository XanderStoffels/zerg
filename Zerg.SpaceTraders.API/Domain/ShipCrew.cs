namespace Zerg.SpaceTraders.API.Domain;

public class ShipCrew
{
    /// <summary>
    /// The current number of crew members on the ship.
    /// </summary>
    public required int Current { get; set; }
    
    /// <summary>
    /// The minimum number of crew members required to maintain the ship.
    /// </summary>
    public required int Required { get; set; }
    
    /// <summary>
    /// The maximum number of crew members the ship can support.
    /// </summary>
    public required int Capacity { get; set; }
    
    /// <summary>
    /// The rotation of crew shifts. A stricter shift improves the ship's performance. A more relaxed shift improves the crew's morale.
    /// See <see cref="ShipCrewRotation"/>
    /// </summary>
    public required string Rotation { get; set; }
    
    /// <summary>
    /// A rough measure of the crew's morale. A higher morale means the crew is happier and more productive. A lower morale means the ship is more prone to accidents.
    /// </summary>
    public required int Morale { get; set; }
    
    /// <summary>
    /// The amount of credits per crew member paid per hour. Wages are paid when a ship docks at a civilized waypoint.
    /// </summary>
    public required int Wages { get; set; }
}