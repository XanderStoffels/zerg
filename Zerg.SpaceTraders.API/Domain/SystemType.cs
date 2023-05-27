using System.Diagnostics.CodeAnalysis;

namespace Zerg.SpaceTraders.API.Domain;

[SuppressMessage("ReSharper", "IdentifierTypo")]
public class SystemType
{
    public const string NeutronStar = "NEUTRON_STAR";
    public const string RedStar = "RED_STAR";
    public const string OrangeStar = "ORANGE_STAR";
    public const string BlueStar = "BLUE_STAR";
    public const string YoungStar = "YOUNG_STAR";
    public const string WhiteDwarf = "WHITE_DWARF";
    public const string BlackHole = "BLACK_HOLE";
    public const string Hypergiant = "HYPERGIANT";
    public const string Nebula = "NEBULA";
    public const string Unstable = "UNSTABLE";
}