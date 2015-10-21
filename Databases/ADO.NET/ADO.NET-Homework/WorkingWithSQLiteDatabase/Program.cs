namespace WorkingWithSQLiteDatabase
{
    using System;
    using System.Data.SQLite;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            SQLiteConnection.CreateFile("../../library.sqlite");
            SQLiteConnection dbConnection = new SQLiteConnection("Data Source=../../library.sqlite;Version=3;");
            using (dbConnection)
            {
                dbConnection.Open();
                CreateTableBooks(dbConnection);

                AddBook(dbConnection, "A Game of Thrones", "George R. R. Martin", new DateTime(1996, 8, 6), "0-553-10354-7 ");
                AddBook(dbConnection, "A Clash of Kings", "George R. R. Martin", new DateTime(1998, 11, 16), "0-553-10803-4");

                string books = GetAllBooks(dbConnection);
                Console.WriteLine(books);
                GetBookByName(dbConnection, "Thrones");
            }
        }

        private static void CreateTableBooks(SQLiteConnection dbConnection)
        {
            string commandText = "create table books (" +
                                "id integer primary key autoincrement, " +
                                "title nvarchar(100) not null, " +
                                "author nvarchar(50) not null," +
                                "publishDate datetime," +
                                "isbn nvarchar(17))";
            var command = new SQLiteCommand(commandText, dbConnection);
            command.ExecuteNonQuery();
        }

        private static string GetAllBooks(SQLiteConnection dbConnection)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Listing all books");

            SQLiteCommand command = new SQLiteCommand("select title, author, publishDate, isbn from books", dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            using (reader)
            {
                while (reader.Read())
                {
                    string title = (string)reader["title"];
                    string author = (string)reader["author"];
                    result.Append(string.Format("{0} --> {1}", title, author));
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

        private static void GetBookByName(SQLiteConnection dbConnection, string substring)
        {
            Console.WriteLine("Getting books by name");

            SQLiteCommand command = new SQLiteCommand(
                "select title, author from books where charindex(@substring, title)",
                dbConnection);
            command.Parameters.AddWithValue("@substring", substring);
            SQLiteDataReader reader = command.ExecuteReader();

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

        private static void AddBook(
            SQLiteConnection dbConnection, 
            string title, 
            string author, 
            DateTime publishDate,
            string isbn)
        {
            Console.WriteLine("Adding new book");

            SQLiteCommand command = new SQLiteCommand(
                "insert into books (title, author, publishDate, isbn) values (@title, @author, @publishDate, @isbn)",
                dbConnection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@publishDate", publishDate);
            command.Parameters.AddWithValue("@isbn", isbn);

            var queryResult = command.ExecuteNonQuery();
            Console.WriteLine("{0} row(s) affected", queryResult);
            Console.WriteLine(new string('-', 90));
        }
    }
}
