using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SuperheroStats.Data;

namespace SuperheroStats.Services
{
	public class HeroService : IHeroService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;
        private readonly IConfiguration _config;

        public HeroService(HttpClient httpClient, IConfiguration config)
        {
            _config = config;
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", _config["HeroApiHost"]);
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", _config["HeroApiKey"]);
        }
        public async Task<IEnumerable<HeroModel>> GetHeroes()
        {
            return await _httpClient.GetFromJsonAsync<HeroModel[]>("heroes");
        }

        public async Task<HeroModel> GetHero(string name)
        {
            return await _httpClient.GetFromJsonAsync<HeroModel>($"?hero={name}");

        }
    }
}
