using System.Net.Http;

namespace RemoteProxyDesignPattern.ExampleTwo
{
    //Remote Proxy:
    //This will interact with the remote weather service using an HTTP client.
    public class WeatherServiceProxy : IWeatherService
    {
        private readonly HttpClient _httpClient;
        private const string baseUrl = "https://weatherapi.example.com";

        public WeatherServiceProxy()
        {
            _httpClient = new HttpClient();
        }


        public string GetCurrentWeather(string city)
        {
            var response = _httpClient.GetStringAsync($"{baseUrl}/current?city={city}").Result;
            return response; // This might return a JSON string which can be further deserialized.
        }
    }
}
