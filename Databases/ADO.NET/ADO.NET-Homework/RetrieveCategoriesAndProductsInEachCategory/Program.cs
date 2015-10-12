namespace RetrieveCategoriesAndProductsInEachCategory
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;

    public class Program
    {
        private static SqlConnection dbConnection;

        public static void Main()
        {
            ConnectToDB();
            using (dbConnection)
            {
                var command = new SqlCommand("SELECT p.ProductName, c.CategoryName " +
                    "FROM Products p JOIN Categories c ON p.CategoryID = c.CategoryID ", dbConnection);
                var reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string productName = (string)reader["ProductName"];
                        string categoryName = (string)reader["CategoryName"];                        
                        Console.WriteLine("{0} - {1}", productName, categoryName);
                    }
                }
            }
        }

        private static void ConnectToDB()
        {
            ConnectionStringSettings dbConnectionString = ConfigurationManager.ConnectionStrings["SQLDB"];
            dbConnection = new SqlConnection(dbConnectionString.ConnectionString);
            dbConnection.Open();
        }
    }
}
