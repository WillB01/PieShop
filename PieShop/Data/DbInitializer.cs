using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Pies.Any())
            {
                context.AddRange(

                new Pie() { Name = "Blueberry Pie", Price = 12.54M },
                new Pie() { Name = "Strawberry Pie", Price = 20.54M },
                new Pie() { Name = "Pumpkin Pie", Price = 200.54M }
                );
                

                context.SaveChanges();

            }

        }
    }
}
