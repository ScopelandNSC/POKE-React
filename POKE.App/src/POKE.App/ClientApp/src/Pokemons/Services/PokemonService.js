import apiHelper from '../../Common/Helpers/ApiHelper';

class PokemonService {
    async getPokemon(pokemonId) {
        var response = await apiHelper.getAsync(`api/Pokemon/${pokemonId}`);
        return response.data;
    }
}

export default PokemonService;
