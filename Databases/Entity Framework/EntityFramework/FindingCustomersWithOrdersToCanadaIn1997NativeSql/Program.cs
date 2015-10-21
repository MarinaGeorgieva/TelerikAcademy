// 4. Implement previous by using native SQL query and executing it through the DbContext.

namespace FindingCustomersWithOrdersToCanadaIn1997NativeSql
{
    using System;

    using CreatingNorthwindDbContext;

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
                var query = @"SELECT c.ContactName AS Customer, o.ShipCountry, o.OrderDate 
                              FROM Customers c JOIN Orders o ON o.CustomerID = c.CustomerID
                              WHERE o.ShipCountry = 'Canada' AND 
                                    o.OrderDate BETWEEN '1997-01-01' AND '1997-12-31'";
                var customers = db.Database.SqlQuery<OrdersToCanadaIn1997>(query);

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer);
                }
            }
        }
    }
}
