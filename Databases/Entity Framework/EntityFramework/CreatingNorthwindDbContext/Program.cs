// 1. Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database.

namespace CreatingNorthwindDbContext
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                var products = db.Products.Select(p => p.ProductName).ToList();

                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }
}
