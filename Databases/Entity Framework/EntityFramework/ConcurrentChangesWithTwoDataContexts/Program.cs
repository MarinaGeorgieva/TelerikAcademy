// 7. Try to open two different data contexts and perform concurrent changes on the same records.

namespace ConcurrentChangesWithTwoDataContexts
{
    using System;
    using System.Linq;

    using CreatingNorthwindDbContext;

    public class Program
    {
        public static void Main()
        {
            using (var firstDb = new NorthwindEntities())
            {
                var product = firstDb.Products.First();
                Console.WriteLine("Initial product name: {0}", product.ProductName);

                product.ProductName = "New Product";
                Console.WriteLine("Product name after change: {0}", product.ProductName);

                using (var secondDb = new NorthwindEntities())
                {
                    var otherProduct = secondDb.Products.First();
                    Console.WriteLine("Initial product name: {0}", otherProduct.ProductName);

                    otherProduct.ProductName = "Another New Product";
                    Console.WriteLine("Product name after change: {0}", otherProduct.ProductName);

                    firstDb.SaveChanges();
                    secondDb.SaveChanges();

                    Console.WriteLine("Product name after save changes: {0}", otherProduct.ProductName);
                }

                Console.WriteLine("Product name after save changes: {0}", product.ProductName);
            }
        }
    }
}
