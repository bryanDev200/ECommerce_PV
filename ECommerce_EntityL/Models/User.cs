using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_EntityL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastNames { get; set; }
        public int Dni { get; set; }
        public int CellPhone { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
        public HashSet<UserRole> Roles { get; set; }
    }
}