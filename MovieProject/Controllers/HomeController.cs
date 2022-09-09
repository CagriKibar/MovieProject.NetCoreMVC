using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _movieContext;
        public HomeController(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }
        public IActionResult Index(int? id)
        {
            var movies = _movieContext.Movies.ToList();
            if (id != null)
            {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }

           
            return View(movies);
        }
        
        public IActionResult Details(int id)
        {
            

            return View(_movieContext.Movies.Where(p => p.MovieId == id).FirstOrDefault());
        }

    }
}
