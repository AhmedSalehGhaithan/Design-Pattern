using System;
using System.Collections.Generic;

namespace CacheProxyDesignPattern.ExampleThree
{
    public class CachedWeatherService : IWeatherService
    {
        private readonly IWeatherService _service;
        private readonly Dictionary<string, (string weather, DateTime timestamp)> _cache = new Dictionary<string, (string weather, DateTime timestamp)>();
        private readonly TimeSpan cacheDuration = TimeSpan.FromMinutes(10);

        public CachedWeatherService(IWeatherService service)
        {
            _service = service;
        }
        public string GetWeather(string city)
        {
            if(_cache.ContainsKey(city))
            {
                var (weather, timestamp) = _cache[city];
                if(DateTime.UtcNow - timestamp < cacheDuration)
                {
                    Console.WriteLine($"Returning cached weather data for {city}.");
                    return weather;
                }
            }

            var freshWeather = _service.GetWeather(city);
            _cache[city] = (freshWeather, DateTime.UtcNow);
            return freshWeather;
        }
    }
}
