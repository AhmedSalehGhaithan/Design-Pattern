namespace Logistics_Application.LogisticsApplication
{
    internal class ShipFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
