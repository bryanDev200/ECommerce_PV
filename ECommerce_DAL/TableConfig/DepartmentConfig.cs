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
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable(name: "tb_departments");

            builder.HasKey(prop => prop.Id).HasName("department_id");

            builder.Property(prop => prop.Description)
                .HasColumnName("description")
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}