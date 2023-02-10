using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_EntityL.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}