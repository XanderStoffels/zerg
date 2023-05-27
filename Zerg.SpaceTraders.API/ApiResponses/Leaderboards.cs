namespace Zerg.SpaceTraders.API.ApiResponses;

public class Leaderboards
{
    public required List<MostCredit> MostCredits { get; set; } = new();
    public required List<MostSubmittedChart> MostSubmittedCharts { get; set; } = new();
}