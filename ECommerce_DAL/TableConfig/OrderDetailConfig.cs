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
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable(name: "tb_order_details");

            builder.HasKey(prop => new { prop.OrderId, prop.ProductId });

            builder.Property(prop => prop.OrderId)
                .HasColumnName("order_id");

            builder.Property(prop => prop.ProductId)
                .HasColumnName("product_id");

            builder.Property(prop => prop.Quantity)
                .HasColumnName("quantity")
                .IsRequired();

            builder.Property(prop => prop.Price)
                .HasColumnName("price")
                .HasPrecision(precision: 9, scale: 2)
                .IsRequired();
        }
    }
}