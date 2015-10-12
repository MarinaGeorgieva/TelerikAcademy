namespace RetrieveCategoryNameAndDescription
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
                var command = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbConnection);
                var reader = command.ExecuteReader();
                using (reader)
                {
                    Console.WriteLine("Categories");
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string categoryDescription = (string)reader["Description"];
                        Console.WriteLine("{0} - {1}", categoryName, categoryDescription);
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
