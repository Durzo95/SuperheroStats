using System.Net.Http.Json;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SuperheroStats.Data;

namespace SuperheroStats.Services
{
	public class HeroService : IHeroService
    {
        private readonly IMemoryCache _memoryCache;
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;
        private readonly IConfiguration _config;

        public HeroService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public HeroService(HttpClient httpClient, IConfiguration config, IMemoryCache memoryCache)
        {
            _config = config;
            _httpClient = httpClient;
            _memoryCache = memoryCache;
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", _config["HeroApiHost"]);
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", _config["HeroApiKey"]);
        }
        public async Task<IEnumerable<HeroModel>> GetHeroes()
        {
            return await _httpClient.GetFromJsonAsync<HeroModel[]>("heroes");
        }

        public async Task<HeroModel?> GetHero(string name)
        {
            return await _httpClient.GetFromJsonAsync<HeroModel>($"?hero={name}");

        }

        public async Task<HeroModel?> GetHeroCache(string name)
        {
            var hero = _memoryCache.Get<HeroModel>(name);

            if (hero is not null) return hero;

            hero = new HeroModel();
            hero = await GetHero(name);
            _memoryCache.Set(name, hero, TimeSpan.FromDays(1));

            return hero;
        }
    }
}
