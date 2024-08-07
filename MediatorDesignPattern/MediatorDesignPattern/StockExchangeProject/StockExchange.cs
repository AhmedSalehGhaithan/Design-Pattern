using System.Collections.Generic;
using System;
using System.Linq;

namespace MediatorDesignPattern.StockExchangeProject
{
    public class StockExchange : IStockExchange
    {
        // Simplified order-matching logic for illustration purposes
        private Dictionary<string, List<Order>> _buyOrders = new Dictionary<string, List<Order>>();
        private Dictionary<string, List<Order>> _sellOrders = new Dictionary<string, List<Order>>();
        public void PlaceOrder(Trader trader, string stockSymbol, int quantity, OrderType orderType)
        {
            var order = new Order(trader, stockSymbol, quantity, orderType);
            if (orderType == OrderType.Buy && _sellOrders.ContainsKey(stockSymbol) && _sellOrders[stockSymbol].Any())
            {
                var matchingOrder = _sellOrders[stockSymbol].First();
                ExecuteTrade(order, matchingOrder);
                _sellOrders[stockSymbol].Remove(matchingOrder);
            }
            else if (orderType == OrderType.Sell && _buyOrders.ContainsKey(stockSymbol) && _buyOrders[stockSymbol].Any())
            {
                var matchingOrder = _buyOrders[stockSymbol].First();
                ExecuteTrade(order, matchingOrder);
                _buyOrders[stockSymbol].Remove(matchingOrder);
            }
            else
            {
                if (orderType == OrderType.Buy)
                {
                    if (!_buyOrders.ContainsKey(stockSymbol)) _buyOrders[stockSymbol] = new List<Order>();
                    _buyOrders[stockSymbol].Add(order);
                }
                else
                {
                    if (!_sellOrders.ContainsKey(stockSymbol)) _sellOrders[stockSymbol] = new List<Order>();
                    _sellOrders[stockSymbol].Add(order);
                }
            }
        }
        private void ExecuteTrade(Order buyOrder, Order sellOrder)
        {
            Console.WriteLine($"Trade executed: {buyOrder.StockSymbol} - {buyOrder.Quantity} shares @ market price");
        }
    }
}
