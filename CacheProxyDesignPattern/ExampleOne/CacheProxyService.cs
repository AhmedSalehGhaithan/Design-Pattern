using System;
using System.Collections.Generic;

namespace CacheProxyDesignPattern.ExampleOne
{
    public class CacheProxyService : IService
    {
        private readonly IService _service;
        private readonly Dictionary<int, string> _cache = new Dictionary<int, string>();
        public CacheProxyService(IService service)
        {
            _service = service;
        }
        public string GetData(int key)
        {
            if (_cache.ContainsKey(key))
            {
                Console.WriteLine($"Returning cached data for key : {key}");
                return _cache[key];
            }

            string result = _service.GetData(key);
            _cache[key] = result;
            return result;
        }
    }
}
