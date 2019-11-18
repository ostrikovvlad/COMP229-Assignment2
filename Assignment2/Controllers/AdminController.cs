using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class AdminController : Controller
    {
        private IRecipeRepository repository;
        public AdminController(IRecipeRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View("Index", repository.Recipes);
        }
        public ViewResult Edit(int recipeId)
        {
            return View("Edit", repository.Recipes.Where(r => r.RecipeId == recipeId).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult Edit(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.Title} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                return View(recipe);
            }
        }
        public ViewResult Create()
        {
            return View("Edit", new Recipe());
        }

        [HttpPost]
        public IActionResult Delete(int recipeId)
        {
            Recipe deletedRecipe = repository.DeleteRecipe(recipeId);
            if (deletedRecipe != null)
            {
                TempData["message"] = $"{deletedRecipe.Title} has been deleted";
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult AddRecipe()
        {
            ViewBag.Title = "Add Recipe";
            return View();
        }
        [HttpPost]
        public ViewResult AddRecipe(Recipe recipe, int recipePage = 1)
        {
            repository.Add(recipe);
            return View("Index", repository.Recipes);
        }
    }
}