using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessEntities.Models;

namespace FirstNetCoreApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieContext _context;

        public IList<Movie> Movie { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }

        public IndexModel(MovieContext context)
        {
            _context = context;
        }
                
        public async Task OnGetAsync(string movieGenre,string searchString)
        {
            MovieGenre = movieGenre;
            var genreQuery = _context.Movie.OrderBy(x => x.Genre).Select(x => x.Genre);

            var movies = _context.Movie.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(x => x.Title.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre.ToLower() == movieGenre.ToLower());
            }

            Genres = new SelectList(await genreQuery.Distinct().ToListAsync(),MovieGenre);
            
            Movie = await movies.ToListAsync();
        }
    }
}
