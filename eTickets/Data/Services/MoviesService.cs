using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly AppDBContext _context;
        public MoviesService(AppDBContext context)
        {
            _context = context;
        }

        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            var result = await _context.Movies.Include(n => n.Cinema).ToListAsync();
            return result;
        }

        public Movie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Movie Update(int id, Movie newMovie)
        {
            throw new NotImplementedException();
        }
    }
}
