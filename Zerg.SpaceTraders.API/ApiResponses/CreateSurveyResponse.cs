using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class CreateSurveyResponse
{
    public required Cooldown Cooldown { get; set; }
    public required List<Survey> Surveys { get; set; } = new();
}