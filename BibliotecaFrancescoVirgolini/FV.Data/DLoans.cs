using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FV.Entities;

namespace FV.Data
{
    public class DLoans
    {
        public DataTable List(int id)
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("list_teacher_loans", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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

        public DataTable Search(int id, DateTime date)
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", SqlDbType.Int)
                {
                    Value = id
                },
                new SqlParameter("@date", SqlDbType.Date)
                {
                    Value = date
                }
            };

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("search_teacher_loans", connection);
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.AddRange(parameters);
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

        public bool IsBookLoanable(int id)
        {
            bool result;
            SqlConnection connection = new SqlConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", SqlDbType.Int)
                {
                    Value = id
                },
                new SqlParameter("@loanable", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                }
            };

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("is_book_loanable", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddRange(parameters);
                connection.Open();
                command.ExecuteNonQuery();

                result = Convert.ToBoolean(parameters[1].Value);
                return result;
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

        public bool TeacherHasLoanedBook(int bookId, int teacherId) 
        {
            SqlDataReader reader;
            DataTable table = new();
            SqlConnection connection = new SqlConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@bookId", SqlDbType.Int)
                {
                    Value = bookId
                },
                new SqlParameter("@teacherId", SqlDbType.Int)
                {
                    Value = teacherId
                }
            };

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("teacher_has_loaned_book", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddRange(parameters);
                connection.Open();
                
                reader = command.ExecuteReader();

                table.Load(reader);
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

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool Insert(int bookId, int teacherId, DateTime loanDate, DateTime returnDate)
        {
            int copyId = 0;
            bool success = false;

            try
            {
                copyId = GetCopyId(bookId);
            }
            catch (Exception)
            {
                throw;
            }

            if (copyId == 0)
                return false;

            SqlConnection connection = new SqlConnection();
            SqlParameter[] parameters = {
                new SqlParameter("@loanDate", SqlDbType.Date) {
                    Value = loanDate
                },
                new SqlParameter("@returnDate", SqlDbType.Date) {
                    Value = returnDate
                },
                new SqlParameter("@copyId", SqlDbType.Int) {
                    Value = copyId
                },
                new SqlParameter("@teacherId", SqlDbType.Int) {
                    Value = teacherId
                }
            };

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("insert_loan", connection);
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.AddRange(parameters);
                connection.Open();

                success = command.ExecuteNonQuery() == 1;
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

            return success;
        }

        private int GetCopyId(int id)
        {
            int copyId = 0;
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection();

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("get_loanable_books", connection);
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                connection.Open();

                result = command.ExecuteReader();

                table.Load(result);
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

            if(table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];

                copyId = row.Field<int>("copies_id");
            }

            return copyId;
        }
    }
}
