using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_EntityL.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<Order> Orders { get; set; }
    }
}