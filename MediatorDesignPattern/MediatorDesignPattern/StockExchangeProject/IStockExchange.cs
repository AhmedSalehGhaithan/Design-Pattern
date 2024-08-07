namespace MediatorDesignPattern.StockExchangeProject
{
    // Mediator
    public interface IStockExchange
    {
        void PlaceOrder(Trader trader, string stockSymbol, int quantity, OrderType orderType);
    }
}
