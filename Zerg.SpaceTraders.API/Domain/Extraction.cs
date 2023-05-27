namespace Zerg.SpaceTraders.API.Domain;

public class Extraction
{
    public required string ShipSymbol { get; set; }
    
    public required ExtractionYield Yield { get; set; }
}