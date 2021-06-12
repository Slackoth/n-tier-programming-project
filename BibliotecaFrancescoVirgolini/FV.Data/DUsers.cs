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
    public class DUsers
    {
        public Users SignIn(string email, string password)
        {
            SqlDataReader result;
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@email", SqlDbType.VarChar)
                {
                    Value = email
                },
                new SqlParameter("@password", SqlDbType.VarChar)
                {
                    Value = password
                }
            };

            try
            {
                connection = Connection.GetInstance().CreateConnection();
                SqlCommand command = new SqlCommand("sign_in_user", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddRange(parameters);
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
                
                return new Users() 
                { 
                    UsersId = row.Field<int>("users_id"),
                    FirstName = row.Field<string>("first_name"),
                    LastName = row.Field<string>("last_name"),
                    Email = row.Field<string>("email"),
                    Role = row.Field<bool>("user_role")
                };
            }
            else
            {
                return Users.EmptyUser();
            }
        }

        public void BeginSession(Users user)
        {
            SessionManagement.GetInstance().BeginSession(user);
        }

        public void ExpireSession()
        {
            SessionManagement.GetInstance().ExpireSession();
        }

        public bool GetUserSessionRole() 
        {
            return Convert.ToBoolean(SessionManagement.GetInstance().GetSessionProperty("role"));
        }
    }
}
