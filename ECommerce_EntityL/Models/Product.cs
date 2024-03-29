﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_EntityL.Models
{
   public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int SubCategoryId { get; set; }
        public HashSet<Image> Images { get; set; }
        public Subcategory Subcategory { get; set; }
        public DateTime RegistrationDate { get; set;}
        public HashSet<OrderDetail> OrderDetails { get; set; }  
        public HashSet<ProductBrand> ProductsBrand { get; set; }
    }
}