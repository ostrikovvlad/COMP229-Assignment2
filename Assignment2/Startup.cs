using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Assignment2.Models;
using Microsoft.AspNetCore.Identity;

namespace Assignment2
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration conf) => Configuration = conf;

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:TastyRecipes:ConnectionString"]));
            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration["Data:TastyRecipesIdentity:ConnectionString"]));
            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<AppIdentityDbContext>()
                    .AddDefaultTokenProviders();
                ;

            services.AddTransient<IRecipeRepository, EFRecipeRepository>();
            services.AddTransient<IReviewRepository, EFReviewRepository>();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "search-pagination",
                template: "Recipe/List/{keyword?}/Page{recipePage}",
                defaults: new { Controller = "Recipe", action = "List"}
                );
                routes.MapRoute(
                name: "pagination",
                template: "Recipe/List/Page{recipePage}",
                defaults: new { Controller = "Recipe", action = "List", recipePage = 1 }
                );
            routes.MapRoute(
                name: "details",
                template: "Recipe/Details/Recipe{recipeId}",
                defaults: new { Controller = "Recipe", action = "ViewRecipe" });
            routes.MapRoute(
                    name:"editing",
                    template: "Admin/Edit/Recipe{recipeId}",
                    defaults: new { Controller = "Admin", action = "Edit"});
                routes.MapRoute(
                    name: "adminIndex",
                    template: "Admin/Index/Page{recipePage}",
                    defaults: new {Controller = "Admin", action = "Index", recipePage = 1 }
                    );
            routes.MapRoute(name: "default",
                template: "{controller=Recipe}/{action=Index}");
            //routes.MapRoute(name: "review",
            //    template: "Recipe/LeaveReview/Recipe{recipeId}",
            //        defaults: new { Controller = "Recipe", action = "LeaveReview" });

            }
            );
            SeedData.EnsurePopulated(app);
            IdentitySeedData.EnsurePopulated(app);
        }
    }
}
