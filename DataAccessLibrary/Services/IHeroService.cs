using SuperheroStats.Data;

namespace SuperheroStats.Services
{
	public interface IHeroService
    {
        Task<IEnumerable<HeroModel?>> GetHeroes();
        Task<HeroModel?> GetHero(string name);
        Task<HeroModel?> GetHeroCache(string heroName);
    }
}
