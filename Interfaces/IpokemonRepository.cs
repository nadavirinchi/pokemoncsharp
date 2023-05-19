using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IpokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemonByEmail(string name);
        decimal GetPokemonRating(int pokeId);
        bool PokemonExists(int pokeId);
    }
}
