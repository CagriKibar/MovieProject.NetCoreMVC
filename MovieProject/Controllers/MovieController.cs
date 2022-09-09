using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext _movieContext;

        public MovieController(MovieContext movieContext )
        {
            _movieContext=movieContext;
        }

        public IActionResult Index()
        {
            
            return View(_movieContext.Movies.ToList());
        }
        

        [HttpGet]
        public IActionResult AddMovie()
        {
            List<SelectListItem> values = (from x in _movieContext.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = values;
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
           
            if (ModelState.IsValid)
            {
                _movieContext.Add(movie);
                _movieContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        


       public IActionResult DeleteMovie(int id)
        {
            var movie = _movieContext.Movies.FirstOrDefault(p => p.MovieId == id);
            _movieContext.Remove(movie);
            _movieContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            
            return View(_movieContext.Movies.Where(p => p.MovieId == id).FirstOrDefault());
        }
       
        
    }
}
