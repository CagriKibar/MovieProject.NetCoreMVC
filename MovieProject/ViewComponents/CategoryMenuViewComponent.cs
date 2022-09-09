using Microsoft.AspNetCore.Mvc;
using MovieProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieProject.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        MovieContext _movieContext;

        public CategoryMenuViewComponent(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public  IViewComponentResult Invoke()
        {
            List<Category> categories = _movieContext.Categories.ToList();
            return View(categories);
        }
       
    }
}
