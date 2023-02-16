using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_EntityL.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public HashSet<UserRole> Users { get; set; }
        public HashSet<RolePermission> Permissions { get; set; }
    }
}