namespace Zerg.SpaceTraders.API.ApiResponses;

public class ServerStatusResponse
{
    public required string Status { get; set; }
    public required string Version { get; set; }
    public required string ResetDate { get; set; }
    public required string Description { get; set; }
    public required Stats Stats { get; set; }
    public required Leaderboards Leaderboards { get; set; }
    public required ServerResets ServerResets { get; set; }
    public required List<Announcement> Announcements { get; set; } = new();
    public required List<Link> Links { get; set; } = new();
}