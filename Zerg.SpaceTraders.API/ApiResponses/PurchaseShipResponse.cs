using Zerg.SpaceTraders.API.Domain;

namespace Zerg.SpaceTraders.API.ApiResponses;

public class PurchaseShipResponse
{
    public required PurchaseShipResponseData Data { get; set; }

    public class PurchaseShipResponseData
    {
        public required Agent Agent { get; set; }
        public required Ship Ship { get; set; }
        public required ShipyardTransaction Transaction { get; set; }
    }
}