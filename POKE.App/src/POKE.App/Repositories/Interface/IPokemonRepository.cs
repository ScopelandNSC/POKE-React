using POKE.App.Dtos.Pokemon;

namespace POKE.App.Repositories.Interface
{
    public interface IPokemonRepository
    {
        BasePokemon GetPokemon(string pokemonName);
    }
}
