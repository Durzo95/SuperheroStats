using SuperheroStats.Data;

namespace SuperheroStats.Services
{
	public interface _IHeroService
    {
        Task<IEnumerable<Hero>> GetHeroes();
        Task<Hero> GetHero(string name);
    }
}
