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
        public async Task<IEnumerable<Hero>> GetHeros()
        {
            return await _httpClient.GetFromJsonAsync<Hero[]>("heroes");
        }
    }
}
