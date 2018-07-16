using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstNetCoreMVC.Models;
using BusinessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using BusinessLayer.DTOs;
using FirstNetCoreMVC.ViewModels;
using AutoMapper;

namespace FirstNetCoreMVC.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class HomeController : Controller
    {
        private IHomeService _service;
        private IMapper _mapper;

        public HomeController(IHomeService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            ViewData["Message"] = "Your application description page.";
            List<MoviesByGenreViewModel> movViewModel = _mapper.Map<List<MoviesByGenreDTO>, List<MoviesByGenreViewModel>>(await _service.GetMoviesGroupByGenres().ToListAsync());
            return View(movViewModel);
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
