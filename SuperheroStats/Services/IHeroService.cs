using SuperheroStats.Data;

namespace SuperheroStats.Services
{
	public interface IHeroService
    {
        Task<IEnumerable<Hero>> GetHeros();
    }
}
