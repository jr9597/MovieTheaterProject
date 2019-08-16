using Dapper; //an orm we use on top of sql client
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration; //allows to access the appsettings
//using MovieTheaterWebApp.Business;
using MovieTheater.Core.Models;
using System.Collections.Generic;
using System.Data.SqlClient; //sqlclient is a lowlevel library to access the database
using System.Linq;

using MovieTheater.Data.Repositories.Interfaces;
using MovieTheater.Data.Repositories;
using System.Threading.Tasks;

namespace MovieTheaterWebApp.APIControllers
{
    [Route("api/Movies")]
    [ApiController]
    public class MoviesAPIController : ControllerBase
    {
        private IConfiguration _config;
        private IMoviesRepository _moviesRepository;
        public MoviesAPIController(IConfiguration config, IMoviesRepository moviesRepository) //gets it from appsetting.json
        {
            _config = config;
            _moviesRepository = moviesRepository;
        }

        //GET: api/MoviesAPI
        [HttpGet("{id}")]
        public async Task<IEnumerable<Movie>> GetThis(int id)
        {
            //using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
            //{
            //    var data = db.Query<Movie>("select* from Movies");
            //    return data;
            //
            return await _moviesRepository.GetThis(id);

        }

        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
        //    {
        //        var data = db.Query("Select* from Movies where Id = @id", new { id }).FirstOrDefault();
        //        return data;
        //    }
        //}

        [HttpGet]
            public async Task<IEnumerable<Movie>> Get()
        {
            return await _moviesRepository.GetAll();
        }


        //// GET: api/Movies/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
        //    {
        //        var data = db.Query("select* from Movies where Id = @id", new { id }).FirstOrDefault();
        //        return data;
        //        //var data = db.Query<MoviesFinal>("select* from Movies where Id = @Id", new { Id }). FirstOrDefault();
        //        //This gives me an error
        //        //
        //    }
        //}

        // POST: api/MoviesAPI
        [HttpPost]
        public void Post([FromBody] Movie movie) //What is FromBody
        {
            using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
            {
                //moviesFinal.Id = 

                var data = db.Query(@"
insert into Movies (MovieName, RunTime, DirectorName)
values(@MovieName, @RunTime, @DirectorName);
select* from Movies where MovieName = @MovieName;
", movie).FirstOrDefault(); 
            }
        }

        // PUT: api/MoviesAPI/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Movies/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
            {
                var data = db.Execute("DELETE from Movies where Id = @id", new { id });
            }
        }
    }
}
