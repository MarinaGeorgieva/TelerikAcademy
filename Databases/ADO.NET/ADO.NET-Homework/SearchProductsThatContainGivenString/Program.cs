namespace SearchProductsThatContainGivenString
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;

    public class Program
    {
        private static SqlConnection dbConnection;

        public static void Main()
        {
            Console.Write("Please enter a string to search for: ");
            var input = Console.ReadLine();

            ConnectToDB();
            using (dbConnection)
            {
                var command = new SqlCommand("SELECT ProductName FROM Products " +
                    "WHERE CHARINDEX(@pattern, ProductName) > 0", dbConnection);
                command.Parameters.AddWithValue("@pattern", input);
                var reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string productName = reader["ProductName"].ToString();
                        Console.WriteLine(productName);
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
