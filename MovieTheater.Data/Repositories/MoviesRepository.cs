
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

using Dapper;
using Microsoft.Extensions.Configuration;
using MovieTheater.Core.Models;
using MovieTheater.Data.SQL;
using MovieTheater.Data.Repositories.Interfaces;

namespace MovieTheater.Data.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        //constructor
        private IConfiguration _config;
        public MoviesRepository(IConfiguration config)
        {
            _config = config;
        }
        public async Task<IEnumerable<Movie>> GetAll()
        {
            using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
            {
                var data = await db.QueryAsync<Movie>(MoviesQueries.GetAll); // MovieQueries is a file that stores sql code

                return data;
            }
        }

        public async Task Insert(Movie movie)
        {
            using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
            {
                await db.ExecuteAsync(MoviesQueries.Create, movie);
            }
        }

        public async Task<IEnumerable<Movie>> GetThis(int Id)
        {
            using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
            {
                var data = await db.QueryAsync<Movie>(MoviesQueries.GetThis, new { Id });

                return data;
            }
        }
    }
}

