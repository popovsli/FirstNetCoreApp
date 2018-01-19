﻿using BusinessEntities.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.ViewModels
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
