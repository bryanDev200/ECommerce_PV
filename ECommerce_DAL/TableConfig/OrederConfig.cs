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
    public class OrederConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(name: "tb_orders");

            builder.HasKey(prop => prop.Id).HasName("order_id");

            builder.Property(prop => prop.TransactionId)
                .HasColumnName("transaction_id");

            builder.Property(prop => prop.OrderState)
                .HasColumnName("order_state")
                .IsRequired();

            builder.Property(prop => prop.UserId)
                .HasColumnName("user_id");

            builder.Property(prop => prop.RegisterDate)
                .HasColumnName("register_date")
                .HasColumnType("date")
                .IsRequired();

            builder.Property(prop => prop.Address)
                .HasColumnName("order_address")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(prop => prop.DistrictId)
                .HasColumnName("district_id");

            builder.Property(prop => prop.TotalAmount)
                .HasColumnName("total_amount")
                .HasPrecision(precision: 9, scale: 2)
                .IsRequired();
        }
    }
}