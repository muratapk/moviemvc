using Microsoft.EntityFrameworkCore;
using moviemvc.Data;
using moviemvc.Models.Domain;

namespace moviemvcapi.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DatabaseContext _context;

        public MovieRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Movie> AddMovie(Movie movie)
        {
             var result=await _context.Movies.AddAsync(movie);
             await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            var result = await _context.Movies.Where(x => x.MovieId == id).FirstOrDefaultAsync();
            if (result != null)
            {
                 _context.Movies.Remove(result);
                await _context.SaveChangesAsync();
            }
            return result;
        }

        public async Task<IEnumerable<Movie>> FindAll(int id)
        {
            return await _context.Movies.Where(x=>x.MovieId==id).ToListAsync();
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _context.Movies.ToListAsync();
        }

        public async Task<Movie> GetId(int id)
        {
            return await _context.Movies.FindAsync(id);
        }

        public async Task<IEnumerable<Movie>> Search(string name)
        {
            IQueryable<Movie> sorgu = _context.Movies;
            if (!string.IsNullOrEmpty(name))
            {
                sorgu = sorgu.Where(x => x.Title.Contains(name));
            }
            return await sorgu.ToListAsync();
        }

        public async Task<Movie> UpdateMovie(Movie movie, int id)
        {
            var result=await _context.Movies.Where(x=>x.MovieId==id).FirstOrDefaultAsync();
            if (result != null)
            {
                _context.Movies.Update(movie);
                await _context.SaveChangesAsync();

            }
            return result;
        }
    }
}
