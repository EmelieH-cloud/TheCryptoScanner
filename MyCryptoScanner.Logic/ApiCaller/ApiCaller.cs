using Newtonsoft.Json;

namespace MyCryptopScanner
{
    public class ApiCaller
    {
        private readonly HttpClient _client;

        public ApiCaller()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api.coingecko.com/api/v3/");
        }


        public async Task<T> MakeCall<T>(string url)
        {

            HttpResponseMessage response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                T? result = JsonConvert.DeserializeObject<T>(json);
                if (result != null)
                {
                    return result;
                }
            }

            throw new HttpRequestException("Failed to retrieve coin data.");
        }

        // https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=sek&include_market_cap=false&include_24hr_vol=false&include_24hr_change=false&include_last_updated_at=false&precision=18



    }
}