using InsuranceWebAIProject.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace InsuranceWebAIProject.Services
{
    public class TwitterService
    {
        private readonly HttpClient _client;

        public TwitterService()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("x-rapidapi-key", "Your Api");
            _client.DefaultRequestHeaders.Add("x-rapidapi-host", "Your Api Host");
        }

        public async Task<int> GetFollowersCountAsync(string userId)
        {
            var url = $"https://twitter241.p.rapidapi.com/followers?user={userId}&count=1";
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<TwitterRoot>(json);

            return data?.result?.legacy?.followers_count ?? 0;
        }
    }
}