namespace FindingCustomersWithOrdersToCanadaIn1997
{
    using CreatingNorthwindDbContext;

    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            FindAllCustomersWithOrdersToCanadaFrom1997();
        }

        private static void FindAllCustomersWithOrdersToCanadaFrom1997()
        {
            using (var db = new NorthwindEntities())
            {
                var customers = db.Orders
                    .Where(o => o.ShipCountry == "Canada")
                    .Where(o => o.OrderDate >= new DateTime(1997, 1, 1))
                    .Where(o => o.OrderDate <= new DateTime(1997, 12, 31))
                    .Select(o => new
                    {
                        ContactName = o.Customer.ContactName,
                        OrderDate = o.OrderDate,
                        ShipCountry = o.ShipCountry
                    })
                    .ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }
    }
}
