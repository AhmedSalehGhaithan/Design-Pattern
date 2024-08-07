using CacheProxyDesignPattern.ExampleOne;
using CacheProxyDesignPattern.ExampleThree;
using CacheProxyDesignPattern.ExampleTwo;
using System;
namespace CacheProxyDesignPattern
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
            IService service = new CacheProxyService(new ActualService());
            Console.WriteLine(service.GetData(1));
            Console.WriteLine(service.GetData(1));  
            Console.WriteLine(service.GetData(2));
        }
        public static void ExampleTwo()
        {
            IProfilePictureService service = new CachedProfilePictureService(new DatabaseProfilePictureService());
            var pic1 = service.GetProfilePicture(1);
            var pic2 = service.GetProfilePicture(1);
            var pic3 = service.GetProfilePicture(2);
        }

        public static void ExampleThree()
        {
            IWeatherService service = new CachedWeatherService(new RemoteWeatherService());
            Console.WriteLine(service.GetWeather("London")); // Fetches from remote API.
            Console.WriteLine(service.GetWeather("London")); // Returns from cache.
            Console.WriteLine(service.GetWeather("Paris"));  // Fetches from remote API.
        }
    }
}
