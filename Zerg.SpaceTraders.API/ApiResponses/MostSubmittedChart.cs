namespace Zerg.SpaceTraders.API.ApiResponses;

public class MostSubmittedChart
{
    public required string AgentSymbol { get; set; }
    public int ChartCount { get; set; }
}