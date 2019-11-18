using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class EFRecipeRepository : IRecipeRepository
    {
        private ApplicationDbContext context;

        public EFRecipeRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Recipe> Recipes => context.Recipes;

        public Recipe Add(Recipe recipe)
        {
            context.Recipes.Add(recipe);
            context.SaveChanges();
            return recipe;
        }

        public Recipe DeleteRecipe(int recipeId)
        {
            Recipe recipeEntry = context.Recipes.Where(r => r.RecipeId == recipeId).FirstOrDefault();
            if(recipeEntry != null)
            {
                context.Recipes.Remove(recipeEntry);
                context.SaveChanges();
            }
            return recipeEntry;
        }

        public void SaveRecipe(Recipe recipe)
        {
            if(recipe.RecipeId == 0)
            {
                context.Recipes.Add(recipe);
            }
            else
            {
                Recipe recipeEntry = context.Recipes.Where(r => r.RecipeId == recipe.RecipeId).FirstOrDefault();
                if (recipeEntry != null)
                {
                    recipeEntry.Title = recipe.Title;
                    recipeEntry.Name = recipe.Name;
                    recipeEntry.Description = recipe.Description;
                    recipeEntry.Ingredients = recipe.Ingredients;
                    recipeEntry.Instruction = recipe.Instruction;
                }
            }
            context.SaveChanges();
        }
    }
}
