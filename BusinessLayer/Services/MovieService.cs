using BusinessEntities.Context;
using BusinessEntities.Models;
using BusinessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class MovieService : IMovieService
    {
        private readonly MovieContext _context;

        public MovieService(MovieContext context)
        {
            _context = context;
        }

        public async Task Add(Movie movie)
        {
            //_context.Movie.Add(movie);
            //await _context.SaveChangesAsync();
           await _context.CommitAsync(movie);
        }

        public async Task Edit(Movie movie)
        {
            try
            {
                _context.Attach(movie).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                //Log the error
                throw ex;
            }
        }

        public IQueryable<Movie> GetAllMovies()
        {
            return _context.Movie.AsNoTracking().AsQueryable();
        }

        public IQueryable<Movie> SearchMovieAsNoTracking(string searchString, string searchGenre, string sortOrder)
        {
            IQueryable<Movie> searchedMovies = GetAllMovies();

            if (!string.IsNullOrEmpty(searchString))
            {
                searchedMovies= searchedMovies.Where(x => x.Title.ToLower().Contains(searchString.ToLower()));
            }
            if (!string.IsNullOrEmpty(searchGenre))
            {
                searchedMovies = searchedMovies.Where(x => x.Genre.ToLower().Contains(searchGenre.ToLower()));
            }
            if (!string.IsNullOrEmpty(sortOrder))
            {
                searchedMovies = searchedMovies.OrderBy(x => x.GetType().GetProperty(sortOrder));
            }

            return searchedMovies;
        }

        public IQueryable<string> GetGenres()
        {
            var genres = from m in _context.Movie
                         orderby m.Genre
                         select m.Genre;
            return genres;
        }

        public async Task<Movie> GetMovie(int? id)
        {
            return await _context.Movie.SingleOrDefaultAsync(m => m.ID == id);
        }

        public bool MovieExists(int id)
        {
            return _context.Movie.Any(e => e.ID == id);
        }

        public async Task RemoveMovie(int id)
        {
            try
            {
                var movie = await GetMovie(id);
                _context.Movie.Remove(movie);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                //Log exception
                throw ex;
            }

        }
    }
}
