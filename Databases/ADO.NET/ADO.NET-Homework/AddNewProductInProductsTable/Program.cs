namespace AddNewProductInProductsTable
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
                InsertProduct("New Product", 1, 1, "10 boxes", 20, 15, 30, 0, 0);
            }
        }

        private static void InsertProduct(
            string productName, 
            int supplierId, 
            int categoryId, 
            string quantityPerUnit,
            decimal unitPrice,
            int unitsInStock,
            int unitsOnOrder,
            int reorderLevel,
            byte discontinued)
        {
            var command = new SqlCommand(
                @"INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) 
                  VALUES 
                  (@productName, @supplierId, @categoryId, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder, @reorderLevel, @discontinued)", 
                dbConnection);

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@supplierId", supplierId);
            command.Parameters.AddWithValue("@categoryId", categoryId);
            command.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
            command.Parameters.AddWithValue("@unitPrice", unitPrice);
            command.Parameters.AddWithValue("@unitsInStock", unitsInStock);
            command.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
            command.Parameters.AddWithValue("@reorderLevel", reorderLevel);
            command.Parameters.AddWithValue("@discontinued", discontinued);

            command.ExecuteNonQuery();
        }

        private static void ConnectToDB()
        {
            ConnectionStringSettings dbConnectionString = ConfigurationManager.ConnectionStrings["SQLDB"];
            dbConnection = new SqlConnection(dbConnectionString.ConnectionString);
            dbConnection.Open();
        }
    }
}
