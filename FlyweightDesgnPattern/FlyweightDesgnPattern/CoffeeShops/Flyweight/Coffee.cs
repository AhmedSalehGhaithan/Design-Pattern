using System;

namespace FlyweightDesignPattern.CoffeeShops.Flyweight
{
    public class Coffee
    {
        public string _Flavor { get; private set; }
        public string _Ingredients { get; private set; }
        public string _Preparation { get; private set; }

        public Coffee(string flavor,string ingredients,string preparation)
        {
            _Flavor = flavor;
            _Ingredients = ingredients;
            _Preparation = preparation;
        }

        public void ServeCoffee(int tableNumber, string customizations = "")
        {
            Console.WriteLine($"Serving {_Flavor} coffee (made with {_Ingredients} and {_Preparation}) to table {tableNumber}. {customizations}");
        }
    }
}
