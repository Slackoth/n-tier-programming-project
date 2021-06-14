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
    public class DAuthors
    {
        public DataTable List() {

            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("list_authors", conn);
                command.CommandType = CommandType.StoredProcedure;

                conn.Open();

                result = command.ExecuteReader();
                table.Load(result);
                return table;

            }
            catch (Exception) {
                throw;
            }
            finally {
                if (conn.State == ConnectionState.Open) {
                    conn.Close();
                }    
            
            }
        }

        public Boolean insert_authorsxbooks(int bookid, int authorid) {
            bool inserted = false;
            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                 new SqlParameter("@bookid", SqlDbType.VarChar) {
                    Value = bookid
                },
                 new SqlParameter("@authorsid", SqlDbType.VarChar) {
                    Value = authorid
                },
            };

            try
            {
                conn = Connection.GetInstance().CreateConnection();
                SqlCommand cmd = new SqlCommand("insert_authorsxbooks", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                conn.Open();

                inserted = cmd.ExecuteNonQuery() == 1;

            }
            catch (Exception)
            {
                throw;
            }

            return inserted;

        }
    }
}
