using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReviewById(int id);
        ICollection<Review> GetReviewsOfAPokemon(int pokemonId);
        bool CreateReview(Review review);
        bool Save();
        bool ReviewExists(int id);
    }
}
