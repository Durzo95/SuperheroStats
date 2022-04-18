using SuperheroStats.Data;

namespace SuperheroStats.Services
{
	public interface IHeroService
    {
        Task<IEnumerable<Hero>> GetHeroes();
        Task<Hero> GetHero(string name);
    }
}
