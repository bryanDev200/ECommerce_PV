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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(name: "tb_products");

            builder.HasKey(prop => prop.Id).HasName("product_id");

            builder.Property(prop => prop.Name)
                .HasColumnName("product_name")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(prop => prop.Description)
                .HasColumnName("product_description")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(prop => prop.Price)
                .HasColumnName("product_price")
                .HasPrecision(precision: 9, scale: 2)
                .IsRequired();

            builder.Property(prop => prop.Stock)
                .HasColumnName("product_stock")
                .IsRequired();

            builder.Property(prop => prop.SubCategoryId)
                .HasColumnName("subcategory_id");

            builder.Property(prop => prop.RegistrationDate)
                .HasColumnName("register_date")
                .HasColumnType("date")
                .IsRequired();
        }
    }
}