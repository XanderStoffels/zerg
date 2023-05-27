
namespace Zerg.Autopilot.Domain;

public class AgentEntity 
{
    public int Id { get; set; }
    public required string Token { get; set; }
    public required string Symbol { get; set; }
}