namespace WriteDataToExcelFile
{
    using System;
    using System.Data.OleDb;

    public class Program
    {
        private const string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
           @"Data Source=../../trainers.xlsx;Extended Properties=Excel 12.0 Xml;";

        private const string NameToAdd = "Peter Petrov";
        private const double ScoreToAdd = 21;

        public static void Main()
        {
            using (var dbConnection = new OleDbConnection(ConnectionString))
            {
                dbConnection.Open();

                InsertNewRowToExcelFile(dbConnection, NameToAdd, ScoreToAdd);                
            }
        }
        private static void InsertNewRowToExcelFile(OleDbConnection dbConnection, string name, double score)
        {
            var excelSchema = dbConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            string sheetName = excelSchema.Rows[0]["TABLE_NAME"].ToString();
            string commandText = "INSERT INTO [" + sheetName + "] (Name, Score) VALUES (@name, @score)";
            var command = new OleDbCommand(commandText, dbConnection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@score", score);

            var queryResult = command.ExecuteNonQuery();
            Console.WriteLine("{0} rows inserted successfully", queryResult);        
        }
    }
}
