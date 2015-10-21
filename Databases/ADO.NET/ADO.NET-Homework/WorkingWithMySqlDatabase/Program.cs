namespace WorkingWithMySqlDatabase
{
    using System;
    using System.Configuration;
    using System.Text;

    using MySql.Data.MySqlClient;

    public class Program
    {
        public static void Main()
        {            
            ConnectionStringSettings dbConnectionString = ConfigurationManager.ConnectionStrings["MySqlDB"];
            MySqlConnection dbConnection = new MySqlConnection(dbConnectionString.ConnectionString);
            dbConnection.Open();
            using (dbConnection)
            {
                string books = GetAllBooks(dbConnection);
                Console.WriteLine(books);

                GetBookByName(dbConnection, "thrones");
                AddBook(dbConnection, "A Dream of Spring", "George R. R. Martin");
            }
        }

        private static string GetAllBooks(MySqlConnection dbConnection)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Listing all books");

            MySqlCommand command = new MySqlCommand("select * from books", dbConnection);
            MySqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    int id = (int)reader["id"];
                    string title = (string)reader["title"];
                    string author = (string)reader["author"];
                    result.Append(string.Format("{0} {1} --> {2}", id, title, author));
                    var publishDate = reader["publishDate"];
                    if (publishDate is DBNull)
                    {
                        result.Append(", Not published yet");
                    }
                    else
                    {
                        result.Append(string.Format(", {0}", publishDate.ToString()));
                    }
                    var isbn = reader["isbn"];
                    if (isbn is DBNull)
                    {
                        result.AppendLine();
                    }
                    else
                    {

                        result.AppendLine(string.Format(", {0}", isbn.ToString()));
                    }
                }
            }

            result.AppendLine(new string('-', 90));
            return result.ToString();
        }

        private static void AddBook(MySqlConnection dbConnection, string title, string author)
        {
            Console.WriteLine("Adding new book");

            MySqlCommand command = new MySqlCommand(
                "insert into books (title, author) values (@title, @author)", 
                dbConnection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);

            var queryResult = command.ExecuteNonQuery();
            Console.WriteLine("{0} row(s) affected", queryResult);
            Console.WriteLine(new string('-', 90));
        }

        private static void GetBookByName(MySqlConnection dbConnection, string substring)
        {
            Console.WriteLine("Getting books by name");

            MySqlCommand command = new MySqlCommand(
                "select title, author from books where locate(@substring, title)", 
                dbConnection);
            command.Parameters.AddWithValue("@substring", substring);
            MySqlDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string title = (string)reader["title"];
                    string author = (string)reader["author"];

                    Console.WriteLine("{0} --> {1}", title, author);
                }
            }

            Console.WriteLine(new string('-', 90));         
        }
    }
}
