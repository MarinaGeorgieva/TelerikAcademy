// 6. Create a database called NorthwindTwin with the same structure as Northwind using the features from DbContext.

namespace CreatingDatabaseNorthwindTwin
{    
    using System;

    using CreatingNorthwindDbContext;

    public class Program
    {
        public static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                Console.WriteLine(db.Database.CreateIfNotExists());
            }            
        }
    }
}
