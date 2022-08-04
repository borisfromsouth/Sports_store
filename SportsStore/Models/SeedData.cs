using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product //1
                    {
                        Name = "Kayak",
                        Description = "12345",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product  //2
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product  //3
                    {
                        Name = "Soccer Ball",
                        Description = "12345",
                        Category = "Soccer",
                        Price = 19.50m
                    },
                    new Product  //4
                    {
                        Name = "Corner Flags",
                        Description = "12345",
                        Category = "Soccer",
                        Price = 34.95m
                    },
                    new Product  //5
                    {
                        Name = "Stadium",
                        Description = "12345",
                        Category = "Soccer",
                        Price = 79500
                    },
                    new Product  //6
                    {
                        Name = "Thinking Cap",
                        Description = "12345",
                        Category = "Chess",
                        Price = 16
                    },
                    new Product  //7
                    {
                        Name = "Unsteady Chair",
                        Description = "12345",
                        Category = "Chess",
                        Price = 29.95m
                    },
                    new Product  //8
                    {
                        Name = "Human Chess Board",
                        Description = "12345",
                        Category = "Chess",
                        Price = 75
                    },
                    new Product  //9
                    {
                        Name = "Bling-Bling King",
                        Description = "12345",
                        Category = "Chess",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
