using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using POKE.App.Config;
using POKE.App.Dtos.Pokemon;
using POKE.App.Services.Interface;

namespace POKE.App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : Controller
    {
        private IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet]
        [Route("{pokemonName}")]
        public BasePokemon GetPokemon(string pokemonName)
        {
            return _pokemonService.GetPokemon(pokemonName);
        }
    }
}