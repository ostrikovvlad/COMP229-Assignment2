using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Review
    {
        [Key]
        private int reviewId;
        private string username;
        public int ReviewId
        {
            get { return reviewId; }
            set { reviewId = UniqueReviewId.GetId(); }
        }

        public int RecipeId { get; set; }
        public string RecipeTitle { get; set; }
        public string Username
        {
            get { return username; }
            set
            {
                if(value == null)
                {
                    username = "Anonymous";
                }
                else
                {
                    username = value;
                }
            }
        }
        public string Comment { get; set; }

    }
}
