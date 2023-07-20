using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;
using BOL;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAL
{
    public class DBManager
    {
        private static string connectionDetails= @"server=localhost;port=3306;user=root; password=root123;database=transflowerLib";
        public static List<Book> getAllBooks()
        {
            List<Book> books = new List<Book>();
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connectionDetails;
            string query = "SELECT * FROM books";
            try
            {
                MySqlCommand cmd= new MySqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string bookName = reader["book_name"].ToString();
                    string author = reader["author"].ToString();
                    DateTime publishdate = DateTime.Parse(reader["publishDate"].ToString());
                    double price = double.Parse(reader["price"].ToString());
                    Book book = new Book(id,bookName, author, publishdate, price);
                    books.Add(book);
                }
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            finally { conn.Close(); }


            return books;
        }

        public static Book GetBook(int id)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = connectionDetails;
            string query = "SELECT * FROM books where id=" + id;
            try
            {
                Book BOOK = new Book();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int ID = int.Parse( reader["id"].ToString());
                    string NAME = reader["book_name"].ToString();
                    string AUTHOR = reader["author"].ToString();
                    DateTime DATE = DateTime.Parse(reader["publishDate"].ToString());
                    double PRICE = double.Parse( reader["price"].ToString());
                    BOOK = new Book(ID, NAME, AUTHOR, DATE, PRICE);
                    return BOOK;
                }
                return BOOK;
            }
            catch(Exception e) { Console.WriteLine(e.Message); }
            finally { connection.Close(); }
        }
    }
}