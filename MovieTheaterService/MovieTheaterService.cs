using System;
using System.Collections.Generic;
using System.Threading.Tasks;


using MovieTheater.Core.Models;
using MovieTheater.Service.Interfaces;
using MovieTheater.Data.Repositories.Interfaces;

namespace MovieTheaterService
{
    public class MovieTheaterService : IMovieTheaterService
    {
        private IMoviesRepository _moviesRepo;
        public MovieTheaterService(IMoviesRepository moviesRepo)
        {
            _moviesRepo = moviesRepo;
        }

        public async Task<System.Collections.Generic.IEnumerable<Movie>> GetAll()
        {
            // TODO: check memory cache ( to see if there's data in your memory so that you dont have to go to the database)
            return await _moviesRepo.GetAll();
        }
        //public Task<IEnumerable<Movie>> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task Insert(Movie movie)
        {
            //int thisId = movie.Id;
            //// TODO: business logic goes here
            //if (_moviesRepo.GetThis(thisId) = null)
            //{
            //    await _moviesRepo.Insert(movie);
            //}

            //else
            //{
            //    throw new Exception("Movie already exists!");
            //}

            await _moviesRepo.Insert(movie);
        }
    }
}
