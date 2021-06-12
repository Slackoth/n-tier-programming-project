using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FV.Entities
{
    public class Users
    {
        public int UsersId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Role { get; set; }

        public static Users EmptyUser()
        {
            return new Users
            {
                UsersId = 0,
                FirstName = "",
                LastName = "",
                Email = "",
                Role = false
            };
        }

        public static bool IsEmpty(Users user)
        {
            return user.UsersId == 0;
        }
    }
}
