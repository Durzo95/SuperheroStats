using SuperheroStats.Data;

namespace SuperheroStats.Services
{
	public class HeroService : IHeroService
    {
        private readonly HttpClient _httpClient;

        public HeroService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Hero>> GetHeros()
        {
            return await _httpClient.GetFromJsonAsync<Hero[]>("heroes");
        }
    }
}
