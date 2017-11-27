using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstNetCoreApp.Models;

namespace FirstNetCoreApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly FirstNetCoreApp.Models.MovieContext _context;

        public IndexModel(FirstNetCoreApp.Models.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
