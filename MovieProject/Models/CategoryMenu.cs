using System.Collections.Generic;

namespace MovieProject.Models
{
    public class CategoryMenu
    {
        public Movie Movie { get; set; }
        public List<Movie> Movies { get; set; }
        public List<Category> Categories { get; set; }
    }
}
