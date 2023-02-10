﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_EntityL.Models
{
   public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock{ get; set; }
        public int SubCategoryId { get; set; }

        public DateTime RegistrationDate { get; set;}
    }
}
