using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_EntityL.Models
{
    public  class ProductBrand
    {
        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
