using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_EntityL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public HashSet<Subcategory> SubCategories{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}