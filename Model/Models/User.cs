using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Salt { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNb { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; } 
    }
}
