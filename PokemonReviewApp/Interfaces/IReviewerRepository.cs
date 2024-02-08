using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewerById(int id);
        ICollection<Review> GetReviewsByReviewer(int id);
        bool CreateReviewer(Reviewer reviewer);
        bool Save();
        bool ReviewerExists(int id);
    }
}
