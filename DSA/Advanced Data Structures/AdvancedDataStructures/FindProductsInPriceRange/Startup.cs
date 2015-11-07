namespace FindProductsInPriceRange
{
    using System;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class Startup
    {
        private const int ProductsCount = 500000;
        private const int SearchesCount = 10000;

        private static readonly Random random = new Random();        

        public static void Main()
        {
            OrderedBag<Product> orderedBag = new OrderedBag<Product>();

            AddProducts(orderedBag);
            FindProductsInPriceRange(orderedBag);            
        }

        private static void FindProductsInPriceRange(OrderedBag<Product> orderedBag)
        {
            for (int i = 0; i < SearchesCount; i++)
            {
                Console.WriteLine("Search: " + (i + 1));

                Product from = new Product("Product", GetRandomNumber(1500, 8000));
                Product to = new Product("Product", GetRandomNumber(8500, 12500));
                var productsInRange = orderedBag.Range(from, true, to, true).Take(20);
                foreach (var product in productsInRange)
                {
                    Console.WriteLine(product);
                }
            }
        }

        private static void AddProducts(OrderedBag<Product> orderedBag)
        {
            for (int i = 0; i < ProductsCount; i++)
            {
                orderedBag.Add(new Product("Product " + (i + 1), GetRandomNumber(10, 17500) + (decimal)i / 100));
            }
        }

        private static int GetRandomNumber(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
        }
    }
}