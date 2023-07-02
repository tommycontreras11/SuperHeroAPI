using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Interfaces;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return Ok(_superHeroService.GetAllHeroes());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var hero = _superHeroService.GetSingleHero(id);
            if (hero is null)
                return NotFound("Sorry, this super hero doesn't exists.");

            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero request)
        {
            var result = _superHeroService.AddHero(request);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(int id, SuperHero request)
        {
            var hero = _superHeroService.UpdateHero(id, request);
            if (hero is null)
                return NotFound("Sorry, this super hero doesn't exists.");

            return Ok(hero);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var hero = _superHeroService.DeleteHero(id);
            if (hero is null)
                return NotFound("Sorry, this super hero doesn't exists.");

            return Ok(hero);
        }
    }
}
