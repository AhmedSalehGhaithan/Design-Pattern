using Decorator_Design_Pattern.CarExample;
using Decorator_Design_Pattern.IceCreamedExample;
using Decorator_Design_Pattern.JuiceExample;
using Decorator_Design_Pattern.OrderExample;
using Decorator_Design_Pattern.PizzaExample;
using System;
namespace Decorator_Design_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //call any example here
            
            Console.ReadKey();
        }

        static void PizzaExample()
        {
            PlainPizza plainPizzaObj = new PlainPizza();
            string plainPizza = plainPizzaObj.MakePizza();
            Console.WriteLine(plainPizza);

            PizzaDecorator ChickenPizzaDecorator = new ChickenPizzaDecorator(plainPizzaObj);
            string chickenPizza = ChickenPizzaDecorator.MakePizza();
            Console.WriteLine($"\n {chickenPizza} using ChickenPizzaDecorator");

            VegPizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(plainPizzaObj);
            string vegPizza = vegPizzaDecorator.MakePizza();
            Console.WriteLine($"\n{vegPizza} using VegPizzaDecorator");
        }
        static void OrderExample()
        {
            var order = new Order();
            order.AddLine(1, 5, 1000);
            order.AddLine(2, 3, 2500);
            order.AddLine(3, 4, 1200);

            IOrderProcessor processor = new OrderProcessor();
            processor.Process(order);
            processor = new OrderProcessorExeptionHandlingDecorator(processor);
            processor.Process(order);
            processor = new OrderProcessorProfilingDecorator(processor);
            processor.Process(order);
            processor = new OrderProcessorQueuingDecorator(processor);
            processor.Process(order);

        }
        static void JuiceExample()
        {
            IJuice juice = new OrangeJuice();
            string juiceType = juice.MakeJuice();
            Console.WriteLine(juiceType);

            Console.WriteLine();

            JuiceDecorator iceDecorator = new IceDecorator(juice);
            string iceString = iceDecorator.MakeJuice();
            Console.WriteLine(iceString);

            Console.WriteLine();

            JuiceDecorator honeyDecorator = new HoneyDecorator(juice);
            string honeyString = honeyDecorator.MakeJuice();
            Console.WriteLine(honeyString);
        }
        static void IceCreamedExample()
        {
            IceCream order = new Basic_IceCream();
            order = new Sprinkles_IceCream(order);
            order = new FruitMix_IceCream(order);
            order = new ChocolateChips_IceCream(order);
            order = new Strawberry_IceCream(order);
            Console.WriteLine(order);
        }
        static void CarExample()
        {
            ICar bmwCar1 = new BMWCar();

            Random num = new Random();
            num.Next(100, 13000);

            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");

            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
            carWithDieselEngine.ManufactureCar();

            ICar bmwCar2 = new BMWCar();
            bmwCar2.ManufactureCar();

            Console.WriteLine();

            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
        }
    }
}
