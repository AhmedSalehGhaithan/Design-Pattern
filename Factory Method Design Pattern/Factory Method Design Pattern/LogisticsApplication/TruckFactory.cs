namespace Logistics_Application.LogisticsApplication
{
    internal class TruckFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
