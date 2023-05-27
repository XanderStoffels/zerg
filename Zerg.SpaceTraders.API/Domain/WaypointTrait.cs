using System.Diagnostics.CodeAnalysis;

namespace Zerg.SpaceTraders.API.Domain;

[SuppressMessage("ReSharper", "IdentifierTypo")]
public class WaypointTrait
{
    /// <summary>
    /// The name of the trait.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// A description of the trait.
    /// </summary>
    public required string Description { get; set; }
    
    public const string Uncharted = "UNCHARTED";
    public const string Marketplace = "MARKETPLACE";
    public const string Shipyard = "SHIPYARD";
    public const string Outpost = "OUTPOST";
    public const string ScatteredSettlements = "SCATTERED_SETTLEMENTS";
    public const string SprawlingCities = "SPRAWLING_CITIES";
    public const string MegaStructures = "MEGA_STRUCTURES";
    public const string Overcrowded = "OVERCROWDED";
    public const string HighTech = "HIGH_TECH";
    public const string Corrupt = "CORRUPT";
    public const string Bureaucratic = "BUREAUCRATIC";
    public const string TradingHub = "TRADING_HUB";
    public const string Industrial = "INDUSTRIAL";
    public const string BlackMarket = "BLACK_MARKET";
    public const string ResearchFacility = "RESEARCH_FACILITY";
    public const string MilitaryBase = "MILITARY_BASE";
    public const string SurveillanceOutpost = "SURVEILLANCE_OUTPOST";
    public const string ExplorationOutpost = "EXPLORATION_OUTPOST";
    public const string MineralDeposits = "MINERAL_DEPOSITS";
    public const string CommonMetalDeposits = "COMMON_METAL_DEPOSITS";
    public const string PreciousMetalDeposits = "PRECIOUS_METAL_DEPOSITS";
    public const string RareMetalDeposits = "RARE_METAL_DEPOSITS";
    public const string MethanePools = "METHANE_POOLS";
    public const string IceCrystals = "ICE_CRYSTALS";
    public const string ExplosiveGases = "EXPLOSIVE_GASES";
    public const string StrongMagnetosphere = "STRONG_MAGNETOSPHERE";
    public const string VibrantAuroras = "VIBRANT_AURORAS";
    public const string SaltFlats = "SALT_FLATS";
    public const string Canyons = "CANYONS";
    public const string PerpetualDaylight = "PERPETUAL_DAYLIGHT";
    public const string PerpetualOvercast = "PERPETUAL_OVERCAST";
    public const string DrySeabeds = "DRY_SEABEDS";
    public const string MagmaSeas = "MAGMA_SEAS";
    public const string Supervolcanoes = "SUPERVOLCANOES";
    public const string AshClouds = "ASH_CLOUDS";
    public const string VastRuins = "VAST_RUINS";
    public const string MutatedFlora = "MUTATED_FLORA";
    public const string Terraformed = "TERRAFORMED";
    public const string ExtremeTemperatures = "EXTREME_TEMPERATURES";
    public const string ExtremePressure = "EXTREME_PRESSURE";
    public const string DiverseLife = "DIVERSE_LIFE";
    public const string ScarceLife = "SCARCE_LIFE";
    public const string Fossils = "FOSSILS";
    public const string WeakGravity = "WEAK_GRAVITY";
    public const string StrongGravity = "STRONG_GRAVITY";
    public const string CrushingGravity = "CRUSHING_GRAVITY";
    public const string ToxicAtmosphere = "TOXIC_ATMOSPHERE";
    public const string CorrosiveAtmosphere = "CORROSIVE_ATMOSPHERE";
    public const string BreathableAtmosphere = "BREATHABLE_ATMOSPHERE";
    public const string Jovian = "JOVIAN";
    public const string Rocky = "ROCKY";
    public const string Volcanic = "VOLCANIC";
    public const string Frozen = "FROZEN";
    public const string Swamp = "SWAMP";
    public const string Barren = "BARREN";
    public const string Temperate = "TEMPERATE";
    public const string Jungle = "JUNGLE";
    public const string Ocean = "OCEAN";
    public const string Stripped = "STRIPPED";

}