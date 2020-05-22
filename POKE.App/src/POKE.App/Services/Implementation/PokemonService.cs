using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using POKE.App.Config;
using POKE.App.Dtos.Pokemon;
using POKE.App.Helpers.Interfaces;
using POKE.App.Services.Interface;

namespace POKE.App.Services.Implementation
{
    public class PokemonService : IPokemonService
    {
        private readonly IOptions<OverwatchApiSettings> _overwatchApiSettings;
        private readonly IApiRequestHelper _apiRequestHelper;

        public PokemonService(IOptions<OverwatchApiSettings> overwatchApiSettings, IApiRequestHelper apiRequestHelper)
        {
            _overwatchApiSettings = overwatchApiSettings;
            _apiRequestHelper = apiRequestHelper;
        }

        public BasePokemon GetPokemon(string pokemonName)
        {
            System.Uri url = new System.Uri(string.Format("{0}/pokemon/{1}", "https://pokeapi.co/api/v2/", pokemonName));   // This should probably go through a service call -- Will do soon

            var response = _apiRequestHelper.Get(url);

            return JObject.Parse(response).ToObject<BasePokemon>();
        }
    }
}
