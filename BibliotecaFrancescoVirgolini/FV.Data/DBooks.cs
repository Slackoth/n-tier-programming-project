using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FV.Entities;
using System.Data.SqlClient;

namespace FV.Data
{
    public class DBooks
    {
        public DataTable List()
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("list_all_books", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                result = command.ExecuteReader();

                table.Load(result);
                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        public DataTable Search(string value, int type)
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            string searchType = SearchType(type);
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand(searchType, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@value", SqlDbType.VarChar).Value = value;

                connection.Open();

                result = command.ExecuteReader();

                table.Load(result);
                return table;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private string SearchType(int type)
        {
            return type switch
            {
                0 => "search_books_by_title",
                1 => "search_books_by_author",
                2 => "search_books_by_editorial",
                3 => "search_books_by_country",
                4 => "search_books_by_language",
                5 => "search_books_by_subject",
                _ => "search_books_by_title"
            };
        }
    }
}
