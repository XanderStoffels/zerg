using System.Text.Json.Serialization;
using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class ListShipsResponse
{
    public required List<Ship> Data { get; set; } = new();
    public required Meta Meta { get; set; }
}