using SuperheroStats.Data;

namespace SuperheroStats.Services
{
	public class _HeroService : _IHeroService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;
        private readonly IConfiguration _config;

        public _HeroService(HttpClient httpClient, IConfiguration config)
        {
            _config = config;
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", _config["HeroApiHost"]);
            _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", _config["HeroApiKey"]);
        }
        public async Task<IEnumerable<Hero>> GetHeroes()
        {
            return await _httpClient.GetFromJsonAsync<Hero[]>("heroes");
        }

        public async Task<Hero> GetHero(string name)
        {
            return await _httpClient.GetFromJsonAsync<Hero>($"?hero={name}");

        }
    }
}
