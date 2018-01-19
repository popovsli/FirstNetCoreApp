using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.DTOs
{
    public class MoviesByGenreDTO
    {
        public string Genre { get; set; }
        public IQueryable<Movie> MoviesName { get; set; }
    }
}
