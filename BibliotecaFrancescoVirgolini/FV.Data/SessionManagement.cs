using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FV.Entities;

namespace FV.Data
{
    public class SessionManagement
    {
        private Users SessionUser = Users.EmptyUser();
        public static SessionManagement instance = null;

        public static SessionManagement GetInstance()
        {
            if (instance == null)
                instance = new SessionManagement();

            return instance;
        }

        public void BeginSession(Users user)
        {
            SessionUser = user;
        }
        public void ExpireSession()
        {
            SessionUser = Users.EmptyUser();
        }

        public string GetSessionProperty(string property)
        {
            return property switch
            {
                "id" => this.SessionUser.UsersId.ToString(),
                "firstname" => this.SessionUser.FirstName,
                "lastname" => this.SessionUser.LastName,
                "email" => this.SessionUser.Email,
                "role" => this.SessionUser.Role.ToString(),
                _ => ""
            };
        }
    }
}
