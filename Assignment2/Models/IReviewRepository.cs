using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public interface IReviewRepository
    {
        IQueryable<Review> Reviews { get; }
        Review Add(Review review);
    }
}
