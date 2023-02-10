using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_EntityL.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Route { get; set; }
        public bool Active { get; set; }
        public HashSet<Role> Roles { get; set;}
    }
}