using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                                new Recipe
                                {
                                    Name = "Martha Stewart",
                                    Title = "Potato perogies",
                                    Description = "Perogies were traditionally served as a meatless dish during Lent, but evolved into a popular side dish. Pierogi bob to the surface of the cooking water when they're done. This recipe Martha Stewart got from her mother. Martha says: My mother used to make it every year on one particular holiday where all of our family would sit together and eat and just enjoy their life. So perogies always bring good memories that warms my heart to me.",
                                    Ingredients = "1 large egg; 2 tablespoon sour cream; 1 cup milk; 1 cup water; 4 1/2 to 5 cups all-purpose flour plus more for dusting; 5 pounds (about 10 medium) baking potatoes, peeled and quartered; 12 tablespoons (1 1/2 sticks) unsalted butter, melted; 2 ounces cheddar cheese, (about 1/2 cup), grated; 4 ounces cream cheese",
                                    Instruction = "Make the dough: In a medium bowl, whisk egg. Add sour cream, and whisk until smooth. Add milk and 1 cup water, and whisk until combined. Slowly add about 3 cups flour, and stir with a wooden spoon to combine.;Turn dough out onto a well-floured surface and work in about 1 cup flour as you knead." +
                                    " Use a plastic scraper to lift dough as it will stick to the counter before flour is worked in. Continue kneading for 8 to 10 minutes, working in another 1/2 cup flour. The dough should be elastic in texture and no longer sticky." +
                                    " Be careful not to add too much flour, as this will toughen dough. Place dough in a lightly floured bowl and cover with plastic wrap and let rest while you prepare filling.;Make the filling: Place potatoes in a large pot, and cover with cold water. Add salt. " +
                                    "Place over high heat, and bring to a boil. Cook until fork-tender. Drain and mash with a potato masher. Add 4 tablespoons melted butter and the cheeses, and continue to mash until well incorporated. Season with salt and pepper to taste. " +
                                    "Place a large pot of salted water over high heat, and bring to a boil. Lay a clean linen towel on your counter, and evenly distribute cornmeal on it to prevent sticking.;On a floured surface, roll out dough to about 1/8 inch thick." +
                                    "Using a glass or cookie cutter measuring 2 1/2 inches in diameter, cut out as many circles as possible. Gather dough scraps together, rolling them out again, and continue cutting.;Form filling into 1 1/2-inch balls, and place a ball in the center of each dough circle. " +
                                    "Holding a circle in your hand, fold dough over filling, and pinch the edges, forming a well-sealed crescent.Transfer to linen towel.Continue this process until all dough circles are filled.; Place pierogi in boiling water in batches.They will sink to the bottom of the pot and then rise to the top.Once they rise, let them cook for about a minute more. Meanwhile, drizzle platter with remaining 8 tablespoons melted butter.Remove pierogi from pot, and transfer to platter to prevent sticking.Serve immediately. "
                                },
                                new Recipe
                                {
                                    Name = "Giada De Laurentis",
                                    Title = "Steak Salad",
                                    Description = "Quick and easy steak salad that will make you lick your fingers. This amazing Italian dish is not only delicious, but also easy making. This salad is perfect for summer patio evenings. Delivered to you by Giada de Laurentis, this recipe will make you love salads even more!",
                                    Ingredients = "1/2 head romaine lettuce, cut into bite-size pieces; 1 large head Belgian endive, thinly sliced crosswise (about 1 1/2 cups); 1/2 red onion, thinly sliced into rings; 3 cups fresh baby arugula; 12 cherry tomatoes, halved; 4 ounces Gorgonzola, coarsely crumbled; Red Wine Vinaigrette, recipe follows; Salt and freshly ground black pepper; 1 pound steak (such as New York, rib-eye or filet mignon), pan-fried or grilled and chilled; 1/2 cup red wine vinegar; 3 tablespoons lemon juice; 2 teaspoons honey; 2 teaspoons salt; 1 cup olive oil",
                                    Instruction = "In a large bowl, combine the romaine lettuce, Belgian endive, red onion, baby arugula and cherry tomatoes, and half of the cheese. Toss the salad with enough vinaigrette to coat. Season the salad with salt and pepper, to taste. Arrange the salad on a platter.; Cut the steaks crosswise into thin slices. Arrange the steak slices atop the salad and sprinkle with the remaining cheese. Drizzle more vinaigrette over the steak slices and serve.; Mix the vinegar, lemon juice, honey, salt, and pepper in a blender. With the machine running, gradually blend in the oil.  "
                                },
                                new Recipe
                                {
                                    Name = "Elise Bauer",
                                    Title = "Borscht",
                                    Description = "Delicious borscht soup made with fresh red beets, beef shank, onions, carrots, potatoes, cabbage, dill, and sour cream.\nDelicious borscht soup made with fresh red beets, beef shank, onions, carrots, potatoes, cabbage, dill, and sour cream.Every time I make or eat borscht I think of my friend and the discovery of how good a soup made primarily of beets can be.The wind is howling outside, if any leaves remain on the trees they are sure to come down today. Here is a wonderfully satisfying beet borscht, perfect for a cold weather day.",
                                    Ingredients = "Extra virgin olive oil or vegetable oil; 1 1/4 pound slice of bone-in beef shank with a lot of meat (or 1 pound of stew beef), excess fat trimmed; 1 large onion, chopped (about 1 1/2 cups); 8 cups beef broth or beef stock, divided 4 cups and 4 cups; 4 large beets (about 1 1/2 pounds), peeled, chopped; 4 carrots (1 lb), peeled, chopped; 1 large russet potato (.75 lb), peeled, cut into 1/2-inch cubes; 2 cups thinly sliced cabbage; 3/4 cup chopped fresh dill; 3 tablespoons red wine vinegar; 1 cup sour cream; Salt and freshly ground black pepper to taste",
                                    Instruction = "Heat 2 teaspoons oil in a large, thick-bottomed pot on medium high heat. Add the shank slice or stew beef. Let the beef brown lightly on one side, then turn over. Add the chopped onions to the pot.Let the onions cook and soften, about 5 minutes.; Pour 4 cups of beef broth over the beef and onions in the pot. Bring to a boil. Lower the heat to a simmer, cover and cook until the meat is falling-off-the-bone tender, about 1 hour 30 minutes.; Peel and chop the beets, carrots, and potatoes into 1/2-inch pieces. Toss the beets and carrots with a teaspoon or two of olive oil and spread them out in a single layer on a foil lined roasting pan. Roast in a 400°F oven for 15 minutes. Toss the potatoes with olive oil and make room for them in the roasting pan, and roast everything an additional 15 minutes.; Once the beef has cooked through until tender in step 2, remove from the pot, and take the pot off the heat. If you are using a beef shank, remove and discard any bone, connective tissue, and excess fat. Chop the meat into bite sized pieces.; Return the pot to the stove and add the remaining broth, the carrots, beets, and the diced potato. Add the chopped meat to the pot, the sliced cabbage, and a half cup of the fresh dill. Bring to a simmer, and cook for another 15 minutes or so, until the cabbage is cooked through. Add the vinegar and season to taste with salt and freshly ground black pepper. I use about 2 teaspoons of salt and 1 teaspoon of pepper, but the amount you use will depend on how salty your beef broth is to begin with. The soup is best made a day ahead. (The longer the soup sits by the way, the more it will all turn the deep red color of beets.) Serve ladled into bowls with a dollop of sour cream and a sprinkling of fresh dill."
                                },
                                new Recipe
                                {
                                    Name = "Denise Browning",
                                    Title = "Brigadeiro Recipe — The Best Chocolate Fudge Balls Ever",
                                    Description = "Brigadeiro (plural Brigadeiros) is a chocolate fudge made with condensed milk, butter, and cocoa powder. It’s LOVE at first bite! Brigadeiro (Portuguese for Brigadier) is the most beloved ‘candy’ of Brazil. From north to south, it is a national passion! It came into being in the 1940s and gets its name from Brigadier Eduardo Gomes, who once ran for president",
                                    Ingredients = "1 can sweetened condensed milk 14-ounce; 1/4 cup baking cocoa powder unsweetened; 1-2 tablespoon unsalted butter (softened) plus extra to grease plate and hands; 1 tablespoon pure vanilla extract; Chocolate vermicelli or good quality chocolate sprinkles",
                                    Instruction = "Whisk the condensed milk and cocoa powder together until homogeneous (no lumps). Then, stir in the butter.; Stove: Cook in a medium non-stick saucepan over medium heat (large burner), stirring constantly, until the mixture thickens and starts to peel away/show the bottom of the pan when you scrape it with your wood spoon (about 5-8 minutes).; Microwave: Pour mixture into a deep microwaveable bowl. If 900 watts, let cook on full power for about 6 minutes -- removing and stirring at least every 2 minutes, or until thick enough to be rolled (when it cools down, mixture will be thicker).; While it is cooking, do not leave the microwave unattended because mixture will rise and possibly bubble over, making a mess. Every time it rises, pause until mixture settles back down. If 1100 watts, cook at 80 % power. Double batches take more time to cook; When brigadeiro is ready, remove either from the stove top or microwave, mix in the vanilla extract and spread mixture onto a greased plate.; Let cool to room temp before starting to roll them into balls with greased hands. Use a 1/2 ( or 1 ) tbsp as measurement.; Then, dredge gently in the chocolate sprinkles until totally covered, and place into paper bonbon cups."
                                }
                    );
                context.SaveChanges();
            }
        }
    }
}
