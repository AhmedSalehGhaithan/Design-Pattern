namespace Logistics_Application.LogisticsApplication
{
    internal class Truck : ITransport
    {
        public double GetDeliveryCost(int distance)
        {
            return 1.00 * distance;
        }
    }
}
