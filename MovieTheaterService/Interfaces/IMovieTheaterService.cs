using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using MovieTheater.Core.Models;

namespace MovieTheater.Service.Interfaces
{
    public interface IMovieTheaterService
    {
        Task Insert(Movie movie);

        Task<IEnumerable<Movie>> GetAll();

        //Task<IEnumerable<Movie>> GetThis();
    }
}
