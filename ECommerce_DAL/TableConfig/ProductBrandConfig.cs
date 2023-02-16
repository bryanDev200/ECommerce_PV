using ECommerce_EntityL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_DAL.TableConfig
{
    public class ProductBrandConfig : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.ToTable(name: "tb_product_brand");

            builder.HasKey(prop => new { prop.BrandId, prop.ProductId });

            builder.Property(prop => prop.BrandId).HasColumnName("brand_id");

            builder.Property(prop => prop.ProductId).HasColumnName("product_id");
        }
    }
}