using ShoppingWebsite.Models;
using ShoppingWebsite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingWebsite.Data
{
    public class DbInitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();
            if (context.Product.Any())
            {
                return; 
            }
            var product = new Product[]
            {
              //new Product{ProductName="Car",Price=1000}
            };
            foreach (Product ps in product)
            {
                context.Product.Add(ps);
            }
            context.SaveChanges();

        }
    }
}