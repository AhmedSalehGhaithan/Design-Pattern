using System.Net.Http;
namespace RemoteProxyDesignPattern.ExampleThree
{
    //Remote Proxy:
    //This is the local representative for the remote service.
    public class BookInventoryProxy : IBookInventory
    {
        private readonly HttpClient _httpClient;
        private const string serviceUrl = "https://remotebookinventory.com/api";
        public BookInventoryProxy()
        {
            _httpClient = new HttpClient();
        }
        public int GetAvailableCopies(string isbn)
        {
            var response = _httpClient.GetStringAsync($"{serviceUrl}/availableCopies?isbn={isbn}").Result;
            return int.Parse(response);
        }
    }
}
