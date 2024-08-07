namespace MediatorDesignPattern.StockExchangeProject
{
    public class Order
    {
        public Trader Trader { get; }
        public string StockSymbol { get; }
        public int Quantity { get; }
        public OrderType OrderType { get; }
        public Order(Trader trader, string stockSymbol, int quantity, OrderType orderType)
        {
            Trader = trader;
            StockSymbol = stockSymbol;
            Quantity = quantity;
            OrderType = orderType;
        }
    }
}
