using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class EFReviewRepository : IReviewRepository
    {
        private ApplicationDbContext context;

        public EFReviewRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Review> Reviews => context.Reviews;

        public Review Add(Review review)
        {
            context.Reviews.Add(review);
            context.SaveChanges();
            return review;
        }
    }
}
