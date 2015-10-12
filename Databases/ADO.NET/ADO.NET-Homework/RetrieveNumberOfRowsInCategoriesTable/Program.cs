namespace RetrieveNumberOfRowsInCategoriesTable
{
    using System;
    using System.Data.SqlClient;
    using System.Configuration;

    public class Program
    {
        private static SqlConnection dbConnection;        

        public static void Main()
        {
            ConnectToDB();
            using (dbConnection)
            {
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Categories", dbConnection);
                int categoriesCount = (int)command.ExecuteScalar();
                Console.WriteLine("Categories count: {0}", categoriesCount);
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
