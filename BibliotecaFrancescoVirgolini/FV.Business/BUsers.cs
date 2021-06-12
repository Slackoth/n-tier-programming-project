using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FV.Entities;
using FV.Data;
using System.Data;

namespace FV.Business
{
    public class BUsers
    {
        public static bool SignIn(string email, string password)
        {
            DUsers dUser = new DUsers();
            Users user = dUser.SignIn(email, password);

            if(Users.IsEmpty(user))
                return false;
            else
            {
                dUser.BeginSession(user);
                return true;
            }
        }

        public static void SignOut()
        {
            DUsers dUser = new DUsers();

            dUser.ExpireSession();
        }

        public static bool GetUserSessionRole()
        {
            return new DUsers().GetUserSessionRole();
        }

        public static DataTable ListTeachers()
        {
            DUsers dUser = new DUsers();

            return dUser.ListTeachers();
        }

        public static DataTable SearchTeachers(string value)
        {
            DUsers dUser = new DUsers();

            return dUser.SearchTeachers(value);
        }
    }
}
