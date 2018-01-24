using BusinessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IHomeService
    {
        IQueryable<MoviesByGenreDTO> GetMoviesGroupByGenres();
    }
}
