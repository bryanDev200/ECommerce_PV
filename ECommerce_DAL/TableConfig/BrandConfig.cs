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
    public class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable(name: "tb_brands");

            builder.HasKey(prop => prop.Id).HasName("brand_id");

            builder.Property(prop => prop.Name)
                .HasColumnName("brand_name")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(prop => prop.Description)
                .HasColumnName("brand_description")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(prop => prop.RegistrationDate)
                .HasColumnName("register_date")
                .HasColumnType("date")
                .IsRequired();
        }
    }
}