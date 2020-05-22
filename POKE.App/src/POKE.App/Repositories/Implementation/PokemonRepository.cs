using POKE.App.Dtos.Pokemon;
using POKE.App.Repositories.Interface;

namespace POKE.App.Repositories.Implementation
{
    public class PokemonRepository : IPokemonRepository
    {
        public BasePokemon GetPokemon(string pokemonName)
        {
            return new BasePokemon();
        }
    }
}
