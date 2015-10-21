// 2. Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.

namespace InsertingUpdatingDeletingCustomers
{
    using System;
    using System.Linq;

    using CreatingNorthwindDbContext;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Inserting new customer");
            string newCustomer = InsertNewCustomer();

            Console.WriteLine("Modifing customer company");
            ModifyCustomerCompany();

            Console.WriteLine("Deleting customer");
            DeleteCustomer();
        }

        private static void DeleteCustomer()
        {
            using (var db = new NorthwindEntities())
            {
                var customer = db.Customers.First();
                db.Customers.Remove(customer);
                db.SaveChanges();
            }
        }

        private static void ModifyCustomerCompany()
        {
            using (var db = new NorthwindEntities())
            {
                var customer = db.Customers
                    .Where(c => c.ContactName == "John Doe")
                    .FirstOrDefault();
                customer.CompanyName = "Modified Company";
                db.SaveChanges();
            }
        }

        private static string InsertNewCustomer()
        {
            using (var db = new NorthwindEntities())
            {
                var newCustomer = new Customer()
                {
                    CustomerID = "ABC",
                    CompanyName = "Telerik",
                    ContactName = "John Doe",
                    ContactTitle = "Owner",
                    Address = "Al. Malinov Str. 31",
                    City = "Sofia",
                    PostalCode = "1784",
                    Country = "Bulgaria",
                    Phone = "(359) 888888888"
                };

                db.Customers.Add(newCustomer);
                db.SaveChanges();
                return newCustomer.CustomerID;
            }
        }
    }
}
