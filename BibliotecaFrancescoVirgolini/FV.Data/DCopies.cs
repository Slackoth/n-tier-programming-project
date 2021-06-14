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
    public class DCopies
    {

        public bool insertCopies(int id) {
            bool inserted = false;

            SqlConnection conn = new SqlConnection();
            SqlParameter[] param = {
                 new SqlParameter("@bookid", SqlDbType.Int) {
                    Value = id
                }
            };

            try
            {
                conn = Connection.GetInstance().CreateConnection();
                SqlCommand cmd = new SqlCommand("insert_copies", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(param);
                conn.Open();

                inserted = cmd.ExecuteNonQuery() == 1;

            }
            catch (Exception) {
                throw;
            }

            return inserted;


        }
    }
}
