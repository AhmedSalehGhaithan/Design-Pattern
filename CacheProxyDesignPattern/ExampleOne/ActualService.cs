using System;

namespace CacheProxyDesignPattern.ExampleOne
{
    // The Actual Service (could be some slow or expensive operations)
    public class ActualService : IService
    {
        public string GetData(int key)
        {
            Console.WriteLine($"Fetching data for key : {key}");
            return $"Data for {key}";
        }
    }
}
