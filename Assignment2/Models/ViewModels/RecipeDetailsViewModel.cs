using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2.Models;

namespace Assignment2.Models.ViewModels
{
    public class RecipeDetailsViewModel
    {
        public Recipe Recipe { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}
