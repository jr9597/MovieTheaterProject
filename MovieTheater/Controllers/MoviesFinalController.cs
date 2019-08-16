using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieTheater.Models;

using Dapper; //an orm we use on top of sql client
using System.Data.SqlClient; //sqlclient is a lowlevel library to access the database
using Microsoft.Extensions.Configuration; //allows to access the appsettings
//using MovieTheaterWebApp.Business;
using MovieTheater.Core.Models;
using MovieTheater.Data.Repositories;
using MovieTheaterService;
using MovieTheater.Service.Interfaces;

namespace MovieTheater.Controllers
{
    public class MoviesFinalController : Controller
    {
        private IMovieTheaterService _movieTheaterService;
        private IConfiguration _config;
        public MoviesFinalController(IConfiguration config, IMovieTheaterService movieTheaterService) //gets it from appsetting.json
        {
            _config = config;
            _movieTheaterService = movieTheaterService;
        }

        public async Task<IActionResult> Index()
        {
            // code if movietheater.service wasn't used
            //using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
            //{
            //    var data = db.Query("select* from Movies");
            //    return View(data);
            //}
            var data = await _movieTheaterService.GetAll();
            return View(data);
        }

        public IActionResult Edit(int? Id, [FromQuery]Movie movie)
        {
            if (Id.HasValue)
            {
                using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
                {// Query cuz we are getting data from database even though there are two actions: one excute, one query
                    var data = db.Query(@" 
select* from Movies where Id = @Id;
delete from Movies where Id = @Id;
", new { Id}).FirstOrDefault();
                    // new {Id} is creating a new object to be passed as a parameter 
                    //WHY CAN'T YOU DO moviesFinal.Id??
                    return View(data);
                }
            }

            Movie emptyMovie = new Movie();
            return View(emptyMovie);
        }

        [HttpPost]
        public IActionResult Edit(Movie moviesFinal)
        {
            using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
            {
                //moviesFinal.Id = 

                var data = db.Query(@"
insert into Movies (MovieName, RunTime, DirectorName)
values(@MovieName, @RunTime, @DirectorName);
select* from Movies where MovieName = @MovieName;
", moviesFinal).FirstOrDefault(); // query always returns a list. So if the returning data is just one item, you need to put FirstOrDefault()

                // var result = db.Query<MoviesFinal>("select* from Movies where MovieNme = @MovieName", moviesFinal); //moviesFinal represents parameters
                // this query is getting data from the database and converting into MoviesFinal class and then saving it in result
                // but we could squeeze this query into the database trip above so we don't make two database trips

                //return View(data);
                return Redirect("/MoviesFinal");
            }
        }
    }
}