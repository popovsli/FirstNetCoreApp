using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstNetCoreMVC.ViewModels
{
    public class MoviesByGenreViewModel
    {
        public string Genre { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
