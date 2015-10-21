// 5. Write a method that finds all the sales by specified region and period (start / end dates).

namespace FindingSalesBySpecifiedRegionAndPeriod
{
    using CreatingNorthwindDbContext;
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            FindSalesByRegionAndPeriod("RJ", new DateTime(1997, 3, 27), new DateTime(1997, 11, 21));
        }

        private static void FindSalesByRegionAndPeriod(string region, DateTime startDate, DateTime endDate)
        {
            using (var db = new NorthwindEntities())
            {
                var sales = db.Orders
                    .Where(o => o.OrderDate >= startDate)
                    .Where(o => o.OrderDate <= endDate)
                    .Where(o => o.ShipRegion == region)
                    .Select(o => new
                    {
                        OrderDate = o.OrderDate,
                        ShipRegion = o.ShipRegion
                    })
                    .ToList();

                foreach (var sale in sales)
                {
                    Console.WriteLine(sale);
                }
            }
        }
    }
}
