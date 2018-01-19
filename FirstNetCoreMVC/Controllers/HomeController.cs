using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstNetCoreMVC.Models;
using BusinessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FirstNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private IHomeService _service;

        public HomeController(IHomeService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            ViewData["Message"] = "Your application description page.";
            var movies = await _service.GetMoviesGroupByGenres().ToListAsync();
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
