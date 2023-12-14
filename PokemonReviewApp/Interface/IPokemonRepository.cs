using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interface
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
    }
}
