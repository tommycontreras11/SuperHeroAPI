namespace SuperHeroAPI.Interfaces
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAllHeroes();
        SuperHero? GetSingleHero(int id);
        List<SuperHero> AddHero(SuperHero request);
        List<SuperHero>? UpdateHero(int id, SuperHero request);
        List<SuperHero>? DeleteHero(int id);
    }
}
