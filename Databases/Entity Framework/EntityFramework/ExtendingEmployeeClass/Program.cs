// 8. By inheriting the Employee entity class create a class which allows 
// employees to access their corresponding territories as property of type EntitySet<T>.

namespace ExtendingEmployeeClass
{
    using System;

    using CreatingNorthwindDbContext;

    public class Program
    {
        public static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                var employee = db.Employees.Find(1);

                foreach (var territory in employee.TerritoriesSet)
                {
                    Console.WriteLine(
                        "Employee: {0} {1}, Territory description: {2}", 
                        employee.FirstName, 
                        employee.LastName,
                        territory.TerritoryDescription);
                }
            }
        }
    }
}
