using FlyweightDesignPattern.CoffeeShops.Flyweight;
using FlyweightDesignPattern.CoffeeShops.FlyweightFactory;
using System.Collections.Generic;
using System;

namespace FlyweightDesignPattern.CoffeeShops.Client
{
    public class CoffeeShop
    {
        private readonly CoffeeFactory _coffeeFactory = new CoffeeFactory();
        private readonly List<Tuple<Coffee, int, string>> _orders = new List<Tuple<Coffee, int, string>>();

        public void TakeOrder(string flavor, int tableNumber, string customizations = "")
        {
            var coffee = _coffeeFactory.GetCoffee(flavor);
            _orders.Add(Tuple.Create(coffee, tableNumber, customizations));
        }
        public void ServeOrders()
        {
            foreach (var order in _orders)
            {
                order.Item1.ServeCoffee(order.Item2, order.Item3);
            }
            _orders.Clear();  // Once served, clear the orders
        }
    }
}
