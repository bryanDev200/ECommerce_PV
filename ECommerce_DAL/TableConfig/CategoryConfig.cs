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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(name: "tb_category");

            builder.HasKey(prop => prop.Id).HasName("category_id");

            builder.Property(prop => prop.Name)
                .HasColumnName("category_name")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(prop => prop.Description)
                .HasColumnName("category_description")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(prop => prop.RegistrationDate)
                .HasColumnName("register_date")
                .HasColumnType("date")
                .IsRequired();
        }
    }
}