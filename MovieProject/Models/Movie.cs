using System;
using System.Collections.Generic;

namespace MovieProject.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }
       
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        

    }
}
