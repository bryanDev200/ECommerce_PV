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
    public class SubCategoryConfig : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.ToTable(name: "tb_subcategories");

            builder.HasKey(prop => prop.Id).HasName("subcategory_id");

            builder.Property(prop => prop.CategoryId)
                .HasColumnName("category_id")
                .IsRequired();

            builder.Property(prop => prop.Name)
                .HasColumnName("name")
                .IsRequired();

            builder.Property(prop => prop.Description)
                .HasColumnName("description")
                .IsRequired();

            builder.Property(prop => prop.RegistrationDate)
                .HasColumnName("register_date")
                .HasColumnType("date")
                .IsRequired();
        }
    }
}