using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;
using Assignment2.Models.ViewModels;

namespace Assignment2.Controllers
{
    public class RecipeController : Controller
    {
        private IRecipeRepository repository;
        private IReviewRepository reviewRepository;
        public int PageSize = 5;

        public RecipeController(IRecipeRepository repo, IReviewRepository revRepo)
        {
            repository = repo;
            reviewRepository = revRepo;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Tasty Recipes";
            return View("Index");
        }
        
        [HttpGet]
        public ViewResult LeaveReview(int recipeId)
        {
            ViewBag.Title = "Leave a Review";
            return View("LeaveReview", repository.Recipes.Where(r => r.RecipeId == recipeId).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult LeaveReview(int recipeId, string recipeTitle, string username, string comment)
        {
            if (ModelState.IsValid)
            {
                reviewRepository.Add(new Review
                { RecipeId = recipeId, RecipeTitle = recipeTitle, Username = username, Comment = comment });
                return RedirectToAction("ViewRecipe", new { recipeId = recipeId});
            }
            else
            {
                return View("ViewRecipe", new RecipeDetailsViewModel
                {
                    Recipe = repository.Recipes.Where(r => r.RecipeId == recipeId).FirstOrDefault(),
                    Reviews = reviewRepository.Reviews.Where(r => r.RecipeId == recipeId)
                });
            }
        }

        public ViewResult List(int recipePage = 1)
        {
            ViewBag.Title = "Our Recipes";
            return View("List", new RecipeListViewModel
            {
                Recipes = repository.Recipes.OrderBy(r => r.RecipeId).Skip((recipePage - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = recipePage,
                    RecipesPerPage = PageSize,
                    TotalRecipes = repository.Recipes.Count()
                }
            });
        }

        public ViewResult ViewRecipe(int recipeId, string returnUrl)
        {
            Recipe recipe = repository.Recipes.FirstOrDefault(r => r.RecipeId == recipeId);
            RecipeDetailsViewModel rec = new RecipeDetailsViewModel
            { Recipe = repository.Recipes.Where(r => r.RecipeId == recipeId).FirstOrDefault(),
                Reviews = reviewRepository.Reviews.Where(r => r.RecipeId == recipeId)};

            ViewBag.Title = "Recipe Details";
            return View("ViewRecipe", rec);
        }
    }
}
