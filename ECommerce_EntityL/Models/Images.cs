﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_EntityL.Models
{
   public class Images
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        public string Route { get; set; }
    }
}
