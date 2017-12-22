using BusinessEntities.Factory;
using BusinessEntities.Interfaces;
using BusinessEntities.Models;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ViewModels.ViewModels;

namespace FirstNetCoreMVC.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieService _context;

        public MoviesController(IMovieService context)
        {
            _context = context;
        }

        // GET: Movies
        public async Task<IActionResult> Index(string searchString, string searchGenre)
        {
            //var genreQuery = from m in _context.Movie
            //                 orderby m.Genre
            //                 select m.Genre;

            var genreQuery = _context.GetGenres();

            //var movies = _context.Movie.AsQueryable();
            var movies = _context.GetAllMovies();

            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(x => x.Title.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(searchGenre))
            {
                movies = movies.Where(x => x.Genre.ToLower() == searchGenre.ToLower());
            }


            IUser user = Factory<IUser, SuperUser>.Create();
            bool isValid = user.Validate();
            user.UserName = "popovsli";
            var validatationType = user.ValidationType;

            MovieViewModel movieViewModel = new MovieViewModel();
            movieViewModel.movieGenre = searchGenre;
            movieViewModel.searchString = searchString;
            movieViewModel.movies = await movies.ToListAsync();
            movieViewModel.genres = new SelectList(await genreQuery.Distinct().ToListAsync());

            return View(movieViewModel);
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var movie = await _context.Movie.SingleOrDefaultAsync(m => m.ID == id);
            var movie = await _context.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            ViewBag.ActionType = nameof(Create);
            return View("CreateEdit");
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Movie movie = await _context.Movie.SingleOrDefaultAsync(m => m.ID == id);
            Movie movie = await _context.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }
            ViewBag.ActionType = nameof(Edit);
            return View("CreateEdit", movie);
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                await _context.Add(movie);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                //_context.Attach(movie).State = EntityState.Modified;
                try
                {
                    await _context.Edit(movie);
                    //await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var movie = await _context.Movie
            //    .SingleOrDefaultAsync(m => m.ID == id);
            var movie = await _context.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var movie = await _context.Movie.SingleOrDefaultAsync(m => m.ID == id);
            //_context.Movie.Remove(movie);
            //await _context.SaveChangesAsync();
            await _context.RemoveMovie(id);
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.MovieExists(id);
            //return _context.Movie.Any(e => e.ID == id);
        }
    }
}
