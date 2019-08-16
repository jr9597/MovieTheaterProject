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

namespace MovieTheater.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _config;
        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult MovieThis()
        {
            using (var db = new SqlConnection(_config["ConnectionString:DefaultConnection"]))
            {
                var data = db.Query("select* from Movies");
                return View(data);
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
