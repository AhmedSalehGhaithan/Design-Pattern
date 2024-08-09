using FlyweightDesignPattern.CoffeeShops.Flyweight;
using System.Collections.Generic;

namespace FlyweightDesignPattern.CoffeeShops.FlyweightFactory
{
    public class CoffeeFactory
    {
        private readonly Dictionary<string, Coffee> _coffees = new Dictionary<string, Coffee>();

        public Coffee GetCoffee(string flavor)
        {
            if (!_coffees.ContainsKey(flavor))
            {
                // For simplicity, let's assume every coffee just has water as its ingredient and is brewed.
                var coffee = new Coffee(flavor, "water", "brewed");
                _coffees.Add(flavor, coffee);
            }
            return _coffees[flavor];
        }
    }
}
