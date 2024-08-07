using RemoteProxyDesignPattern.ExampleOne;
using RemoteProxyDesignPattern.ExampleThree;
using RemoteProxyDesignPattern.ExampleTwo;
using System;
namespace RemoteProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleThree();
            Console.ReadKey();
        }

        public static void ExampleOne()
        {
            //In this example, when the client code calls the GetUserName method on the RemoteUserServiceProxy,
            //the proxy communicates with the RealUserService to get the data.
            //The RealUserService here is a stand-in for a remote service.
            //In a real-world application, the proxy and the real service communication would likely be through
            //protocols like HTTP, gRPC, or some other remote communication method.
            IUserService userService = new RemoteUserServiceProxy();
            string userName = userService.GetUserName(1);
            Console.WriteLine($"Received user name : {userName}");
        }

        public static void ExampleTwo()
        {
            IWeatherService weatherService = new WeatherServiceProxy();

            string weather = weatherService.GetCurrentWeather("London");
            Console.WriteLine($"Current weather in London: {weather}");
            
        }

        public static void ExampleThree()
        {
            //Client Code
            //This is the bookstore trying to fetch the availability of a book.
            // Testing Remote Proxy Design Pattern
            IBookInventory inventory = new BookInventoryProxy();
            int copies = inventory.GetAvailableCopies("978-1234567890");
            Console.WriteLine($"Available copies: {copies}");
            Console.ReadKey();
        }
    }
}
