using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IMovieService
    {
        Task Add(Movie movie);

        Task Edit(Movie movie);

        bool MovieExists(int id);

        Task<Movie> GetMovie(int? id);

        Task RemoveMovie(int id);

        IQueryable<string> GetGenres();

        IQueryable<Movie> GetAllMovies();

        IQueryable<Movie> SearchMovieAsNoTracking(string searchString, string searchGenre, string sortOrder);
    }
}
