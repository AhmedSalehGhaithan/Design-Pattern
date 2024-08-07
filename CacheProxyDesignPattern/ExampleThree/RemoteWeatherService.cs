using System;
using System.Threading;

namespace CacheProxyDesignPattern.ExampleThree
{
    public class RemoteWeatherService : IWeatherService
    {
        public string GetWeather(string city)
        {
            // Simulate a delay for the external API call.
            Thread.Sleep(2000);
            Console.WriteLine($"Fetching weather data for {city} from remote API...");
            return $"{city} : 25°C, Sunny";
        }
    }
}
