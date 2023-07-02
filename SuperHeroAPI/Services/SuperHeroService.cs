using SuperHeroAPI.Interfaces;

namespace SuperHeroAPI.Services
{
    public class SuperHeroService : ISuperHeroService
    {
        private readonly List<SuperHero> superHeroes = new()
        {
            new SuperHero
            {
                Id = 1,
                Name = "Spiderman",
                FirstName = "Peter",
                LastName = "Parker",
                Place = "New York City"
            },
            new SuperHero
            {
                Id = 2,
                Name = "Ironman",
                FirstName = "Tony",
                LastName = "Star",
                Place = "Malibu"
            }
        };

        public List<SuperHero> GetAllHeroes()
        {
            return superHeroes;
        }

        public SuperHero? GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            return hero;
        }

        public List<SuperHero> AddHero(SuperHero request)
        {
            superHeroes.Add(request);
            return superHeroes;
        }

        public List<SuperHero>? UpdateHero(int id, SuperHero request)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;

            return superHeroes;
        }

        public List<SuperHero>? DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            superHeroes.Remove(hero);
            return superHeroes;
        }
    }
}
