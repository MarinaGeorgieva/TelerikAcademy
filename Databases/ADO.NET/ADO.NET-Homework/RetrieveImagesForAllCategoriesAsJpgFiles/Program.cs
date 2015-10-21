namespace RetrieveImagesForAllCategoriesAsJpgFiles
{
    using System.Configuration;
    using System.Data.SqlClient;
    using System.IO;

    public class Program
    {
        private static SqlConnection dbConnection;

        public static void Main()
        {
            ConnectToDB();
            using (dbConnection)
            {
                RetrieveCategoriesImages(dbConnection);
            }
        }

        private static void RetrieveCategoriesImages(SqlConnection dbConnection)
        {
            string commandText = "SELECT CategoryName, Picture FROM Categories";
            var command = new SqlCommand(commandText, dbConnection);
            var reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    categoryName = categoryName.Replace('/', '-');
                    byte[] image = (byte[])reader["Picture"];
                    string fileName = string.Format("../../{0}.jpg", categoryName);
                    StoreImageAsJpgFile(fileName, 78, image);
                }
            }
        }

        private static void StoreImageAsJpgFile(string fileName, int offset, byte[] image)
        {
            FileStream stream = File.OpenWrite(fileName);
            using (stream)
            {
                stream.Write(image, offset, image.Length - offset);
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
