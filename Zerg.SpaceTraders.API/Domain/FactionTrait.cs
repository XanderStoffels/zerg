namespace Zerg.SpaceTraders.API.Domain;

public class FactionTrait
{
    public const string Bureaucratic = "BUREAUCRATIC";
    public const string Secretive = "SECRETIVE";
    public const string Capitalistic = "CAPITALISTIC";
    public const string Industrious = "INDUSTRIOUS";
    public const string Peaceful = "PEACEFUL";
    public const string Distrustful = "DISTRUSTFUL";
    public const string Welcoming = "WELCOMING";
    public const string Smugglers = "SMUGGLERS";
    public const string Scavengers = "SCAVENGERS";
    public const string Rebellious = "REBELLIOUS";
    public const string Exiles = "EXILES";
    public const string Pirates = "PIRATES";
    public const string Raiders = "RAIDERS";
    public const string Clan = "CLAN";
    public const string Guild = "GUILD";
    public const string Dominion = "DOMINION";
    public const string Fringe = "FRINGE";
    public const string Forsaken = "FORSAKEN";
    public const string Isolated = "ISOLATED";
    public const string Localized = "LOCALIZED";
    public const string Established = "ESTABLISHED";
    public const string Notable = "NOTABLE";
    public const string Dominant = "DOMINANT";
    public const string Inescapable = "INESCAPABLE";
    public const string Innovative = "INNOVATIVE";
    public const string Bold = "BOLD";
    public const string Visionary = "VISIONARY";
    public const string Curious = "CURIOUS";
    public const string Daring = "DARING";
    public const string Exploratory = "EXPLORATORY";
    public const string Resourceful = "RESOURCEFUL";
    public const string Flexible = "FLEXIBLE";
    public const string Cooperative = "COOPERATIVE";
    public const string United = "UNITED";
    public const string Strategic = "STRATEGIC";
    public const string Intelligent = "INTELLIGENT";
    public const string ResearchFocused = "RESEARCH_FOCUSED";
    public const string Collaborative = "COLLABORATIVE";
    public const string Progressive = "PROGRESSIVE";
    public const string Militaristic = "MILITARISTIC";
    public const string TechnologicallyAdvanced = "TECHNOLOGICALLY_ADVANCED";
    public const string Aggressive = "AGGRESSIVE";
    public const string Imperialistic = "IMPERIALISTIC";
    public const string TreasureHunters = "TREASURE_HUNTERS";
    public const string Dexterous = "DEXTEROUS";
    public const string Unpredictable = "UNPREDICTABLE";
    public const string Brutal = "BRUTAL";
    public const string Fleeting = "FLEETING";
    public const string Adaptable = "ADAPTABLE";
    public const string SelfSufficient = "SELF_SUFFICIENT";
    public const string Defensive = "DEFENSIVE";
    public const string Proud = "PROUD";
    public const string Diverse = "DIVERSE";
    public const string Independent = "INDEPENDENT";
    public const string SelfInterested = "SELF_INTERESTED";
    public const string Fragmented = "FRAGMENTED";
    public const string Commercial = "COMMERCIAL";
    public const string FreeMarkets = "FREE_MARKETS";
    public const string Entrepreneurial = "ENTREPRENEURIAL";

    /// <summary>
    /// The unique identifier of the trait.
    /// </summary>
    public required string Symbol { get; set; }
    /// <summary>
    /// The name of the trait.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// A description of the trait.
    /// </summary>
    public required string Description { get; set; }
}