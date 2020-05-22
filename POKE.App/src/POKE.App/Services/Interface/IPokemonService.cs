using POKE.App.Dtos.Pokemon;

namespace POKE.App.Services.Interface
{
    public interface IPokemonService
    {
        BasePokemon GetPokemon(string pokemonName);
    }
}
