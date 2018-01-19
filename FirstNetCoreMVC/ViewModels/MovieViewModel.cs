using BusinessEntities.Models;
using FirstNetCoreMVC.Utils.Helpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstNetCoreMVC.ViewModels
{
    public class MovieViewModel
    {
        public PaginatedList<Movie> movies;
        public SelectList genres;
        public string searchGenre { get; set; }
        public string searchString { get; set; }
        public string OrderBy { get; set; }
    }
}
