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

        public bool insertBook(string title, int quant,string isbn, int edition, int pages,string ubication,string desc, int editorial, int country, int language, int subject) {
            //missing part to get type of book
            bool inserted = false;

            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                 new SqlParameter("@title", SqlDbType.VarChar) {
                    Value = title
                },
                 new SqlParameter("@quantity", SqlDbType.Int) {
                    Value = quant
                },
                 new SqlParameter("@isbn", SqlDbType.VarChar) {
                    Value = isbn
                },
                 new SqlParameter("@no_edition", SqlDbType.Int) {
                    Value = edition
                },
                 new SqlParameter("@no_pages", SqlDbType.Int) {
                    Value = pages
                },
                 new SqlParameter("@ubication", SqlDbType.VarChar) {
                    Value = ubication
                },
                 new SqlParameter("@bookdesc", SqlDbType.VarChar) {
                    Value = desc
                },
                new SqlParameter("@editorial_id", SqlDbType.Int) {
                    Value = editorial
                },
                new SqlParameter("@countries_id", SqlDbType.Int) {
                    Value = country
                },
                new SqlParameter("@languages_id", SqlDbType.Int) {
                    Value = language
                },
                 new SqlParameter("@subject_id", SqlDbType.Int) {
                    Value = language
                }
            };

            try {
                conn = Connection.GetInstance().CreateConnection();
                SqlCommand cmd = new SqlCommand("insert_book", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                conn.Open();

                inserted = cmd.ExecuteNonQuery() == 1;
            
            }catch (Exception) {
                throw;
            }

            return inserted;
        
        }

        public bool delete_book(int id) {

            bool deleted = false;
            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                new SqlParameter("@id_book", SqlDbType.Int) {
                    Value = id
                }
            };

            try
            {
                conn = Connection.GetInstance().CreateConnection();
                SqlCommand cmd = new SqlCommand("delete_book", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                conn.Open();

                deleted = cmd.ExecuteNonQuery() == 1;

            }
            catch (Exception)
            {
                throw;
            }


            return deleted;
        }


        public DataTable getid(string title) {

            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                new SqlParameter("@title", SqlDbType.VarChar) {
                    Value = title
                }
            };

            try
            {
                conn = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("book_getid" , conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(param);
                
                conn.Open();

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
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }

        }
    }

}
