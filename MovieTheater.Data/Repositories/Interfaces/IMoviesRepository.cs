using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using MovieTheater.Core.Models;
// here, we want to be able to get baack a list of dogs and create a dog
namespace MovieTheater.Data.Repositories.Interfaces
{
    public interface IMoviesRepository
    {
        //interface is an agreement (contract): this is what dog repositories will agree to do 
        // anyone who implements a dog repository needs to do these things

        Task Insert(Movie movie);

        Task<IEnumerable<Movie>> GetAll();
        // the task wraps the functinos up = means the functinos can be called asynchronously

        Task<IEnumerable<Movie>> GetThis(int Id);
    }
}
