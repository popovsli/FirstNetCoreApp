using BusinessEntities.Context;
using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Services
{
    public class HomeService : IHomeService
    {
        private MovieContext _context;

        public HomeService(MovieContext context)
        {
            _context = context;
        }

        public IQueryable<MoviesByGenreDTO> GetMoviesGroupByGenres()
        {
            var result = from movies in _context.Movie
                         group movies by movies.Genre into movieGrouped
                         select new MoviesByGenreDTO()
                         {
                             Genre = movieGrouped.Key,
                             MoviesName = movieGrouped.AsQueryable()
                         };
            return result;
        }
    }
}
