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
            _context.Movie.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Movie movie)
        {
            _context.Attach(movie).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IQueryable<Movie> GetAllMovies()
        {
            return _context.Movie.AsQueryable();
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
            var movie = await GetMovie(id);
            _context.Movie.Remove(movie);
            await _context.SaveChangesAsync();
        }
    }
}
