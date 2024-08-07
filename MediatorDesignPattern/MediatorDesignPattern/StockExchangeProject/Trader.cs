namespace MediatorDesignPattern.StockExchangeProject
{
    public class Trader
    {
        private IStockExchange _mediator;
        public string Name { get; }
        public Trader(string name, IStockExchange mediator)
        {
            Name = name;
            _mediator = mediator;
        }
        public void PlaceOrder(string stockSymbol, int quantity, OrderType orderType)
        {
            _mediator.PlaceOrder(this, stockSymbol, quantity, orderType);
        }
    }
}
