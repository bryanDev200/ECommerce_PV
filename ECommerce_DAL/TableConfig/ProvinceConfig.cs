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
    public class ProvinceConfig : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable(name: "tb_provinces");

            builder.HasKey(prop => prop.Id).HasName("provimce_id");
            
            builder.Property(prop => prop.Description)
                .HasColumnName("description")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(prop => prop.DepartmentId)
                .HasColumnName("department_id");
        }
    }
}