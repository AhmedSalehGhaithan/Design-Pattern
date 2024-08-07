namespace Logistics_Application.LogisticsApplication
{
    internal class Ship : ITransport
    {
        public double GetDeliveryCost(int distance)
        {
            return 0.50 * distance;
        }
    }
}
