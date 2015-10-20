namespace ReadFromExcelFileAndDisplayData
{
    using System;
    using System.Data.OleDb;

    public class Program
    {
        private const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data Source=../../trainers.xlsx;Extended Properties=Excel 12.0 Xml;";

        public static void Main()
        {
            using (var dbConnection = new OleDbConnection(ConnectionString))
            {
                dbConnection.Open();
                var excelSchema = dbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string sheetName = excelSchema.Rows[0]["TABLE_NAME"].ToString();
                string commandText = "SELECT * FROM [" + sheetName + "]";
                var command = new OleDbCommand(commandText, dbConnection);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        double score = (double)reader["Score"];
                        Console.WriteLine("{0} - {1}", name, score);
                    }
                }
            }
        }
    }
}
