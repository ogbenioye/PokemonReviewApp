using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReviewById(int id);
        ICollection<Review> GetReviewsOfAPokemon(int pokemonId);
        bool ReviewExists(int id);
    }
}
