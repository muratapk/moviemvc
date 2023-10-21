using moviemvc.Models.Domain;

namespace moviemvcapi.Repository
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAll();
        Task<IEnumerable<Movie>> FindAll(int id);
        Task<Movie> GetId(int id);
        Task<Movie> AddMovie(Movie movie);
        Task<Movie> UpdateMovie(Movie movie, int id);
        Task<Movie> DeleteMovie(int id);
        Task<IEnumerable<Movie>> Search(string name);
    }
}
