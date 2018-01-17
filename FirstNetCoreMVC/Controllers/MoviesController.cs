using AutoMapper;
using BusinessEntities.Interfaces;
using BusinessEntities.Models;
using BusinessLayer.Factory;
using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
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
        private readonly IMovieService _service;
        private readonly IMapper _mapper;

        public MoviesController(IMovieService context, IMapper mapper)
        {
            _service = context;
            _mapper = mapper;
        }

        // GET: Movies
        public async Task<IActionResult> Index(string searchString, string searchGenre, string orderBy)
        {
            var genreQuery = _service.GetGenres();

            var movies = _service.SearchMovieAsNoTracking(searchString, searchGenre, orderBy);

            IUser user = Factory<IUser, SuperUser>.Create();
            bool isValid = user.Validate();
            user.UserName = "popovsli";
            var validatationType = user.ValidationType;

            //Using Automapper to map domain model with view model
            //MovieViewModel movViewModel = _mapper.Map<Movie, MovieViewModel>(await movies.FirstOrDefaultAsync());

            MovieViewModel movieViewModel = new MovieViewModel();
            movieViewModel.movieGenre = searchGenre;
            movieViewModel.searchString = searchString;
            movieViewModel.movies = await movies.ToListAsync();
            movieViewModel.genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            movieViewModel.OrderBy = orderBy;

            return View(movieViewModel);
        }

        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _service.GetMovie(id);

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

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                await _service.Add(movie);
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        // GET: Movies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Movie movie = await _context.Movie.SingleOrDefaultAsync(m => m.ID == id);
            Movie movie = await _service.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }
            ViewBag.ActionType = nameof(Edit);
            return View("CreateEdit", movie);
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
                try
                {
                    await _service.Edit(movie);
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
        public async Task<IActionResult> Delete(int? id, string ex)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _service.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(ex))
            {
                ViewBag.Exception = ex;
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _service.RemoveMovie(id);
            }
            catch (DbUpdateException ex)
            {
                RouteValueDictionary routeInfo = new RouteValueDictionary();
                routeInfo.Add("id", id);
                routeInfo.Add("exception", ex);

                return RedirectToAction(nameof(Delete), routeInfo);
            }

            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _service.MovieExists(id);
        }
    }
}
