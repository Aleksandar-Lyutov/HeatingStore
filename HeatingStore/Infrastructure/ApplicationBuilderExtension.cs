using HeatingStore.Data;
using HeatingStore.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeatingStore.Infrastructure
{
    public static class ApplicationBuilderExtension
    {
        public static async Task<IApplicationBuilder> PrepareDatabase(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();

            var services = serviceScope.ServiceProvider;

            await RoleSeeder(services);
            await SeedAdministrator(services);

            var dataCategory = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            SeedCategories(dataCategory);

            var dataManufacturer = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            SeedBrands(dataManufacturer);
            return app;
        }
        private static async Task RoleSeeder(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string[] roleNames = { "Administrator", "Client" };

            IdentityResult roleResult;

            foreach (var role in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);

                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
        private static async Task SeedAdministrator(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            if (await userManager.FindByNameAsync("admin") == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.FirstName = "admin";
                user.LastName = "admin";
                user.Address = "admin";
                user.Email = "admin@abv.bg";
                user.UserName = "admin";

                var result = await userManager.CreateAsync(user, "Admin123456");
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Administrator").Wait();
                }

            }
        }
        private static void SeedCategories(ApplicationDbContext dataCategory)
        {
            if (dataCategory.Categories.Any())
            {
                return;
            }
            dataCategory.Categories.AddRange(new[]
            {
                new Category {CategoryName="Fireplace"},
                new Category {CategoryName="Air conditioner"},
                new Category {CategoryName="Heater"},
                new Category {CategoryName="Convector"},
                new Category {CategoryName="Electric radiator"},
                new Category {CategoryName="Accessories"}
            });
            dataCategory.SaveChanges();
        }
        private static void SeedBrands(ApplicationDbContext dataManufacturer)
        {
            if (dataManufacturer.Manufacturers.Any())
            {
                return;
            }
            dataManufacturer.Manufacturers.AddRange(new[]
            {
                new Manufacturer {ManufacturerName="NEO"},
                new Manufacturer {ManufacturerName="Diplomat"},
                new Manufacturer {ManufacturerName="Electrolux"},
                new Manufacturer {ManufacturerName="Tesy"},
                new Manufacturer {ManufacturerName="Rowenta"}
            });
            dataManufacturer.SaveChanges();
        }
    }
}
