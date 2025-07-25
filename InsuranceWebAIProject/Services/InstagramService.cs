using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using InsuranceWebAIProject.Models;

public class InstagramService
{
    private readonly HttpClient _client;

    public InstagramService()
    {
        _client = new HttpClient();
        _client.DefaultRequestHeaders.Add("x-rapidapi-key", "Your Api");
        _client.DefaultRequestHeaders.Add("x-rapidapi-host", "Your Api Host");
    }

    public async Task<int> GetFollowersCountAsync(string userId)
    {
        var url = $"https://instagram-api-fast-reliable-data-scraper.p.rapidapi.com/profile?user_id={userId}";
        var response = await _client.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();

        var data = JsonConvert.DeserializeObject<InstagramRoot>(json);
        return data?.follower_count ?? 0;
    }
}