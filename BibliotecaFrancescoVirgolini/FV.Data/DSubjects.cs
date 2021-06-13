using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace FV.Data
{
   public class DSubjects
    {
        public DataTable List()
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("list_subjects", conn);
                command.CommandType = CommandType.StoredProcedure;

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
                {
                    conn.Close();
                }

            }
        }
    }
}
