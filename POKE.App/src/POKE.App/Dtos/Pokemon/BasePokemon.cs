using Newtonsoft.Json;

namespace POKE.App.Dtos.Pokemon
{
    public class BasePokemon
    {
        [JsonProperty("id")]
        public int pokemonId { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }
    }
}