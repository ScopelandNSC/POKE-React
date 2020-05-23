import React, { useEffect, useState } from 'react';
import PropTypes from 'prop-types';
import './PokemonInfoCard.css';
import PokemonService from '../../Services/PokemonService'

function PokemonInfoCard(props) {

    const [pokemon, setPokemon] = useState({}); 

    async function getPokemon(name) {
        const pokemonService = new PokemonService();
        return await pokemonService.getPokemon(name);
    }

    // Execute the created function directly
    getPokemon(props.pokemonName).then((returnedPokemon) => {
        setPokemon(returnedPokemon);
    });

    return (
        <div className={'pokemon-info-card'}>
            <div>
                <div className={'pokemon-info-card-number'}>
                    {pokemon.pokemonId}
                </div>
                <div className={'pokemon-info-card-name'}>
                    {pokemon.name}
                </div>
            </div>
        </div>
    );
}

PokemonInfoCard.propTypes = {
    pokemonName: PropTypes.string
};

export default PokemonInfoCard;
