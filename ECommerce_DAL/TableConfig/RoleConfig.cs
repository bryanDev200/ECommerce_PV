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
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable(name: "tb_roles");

            builder.HasKey(prop => prop.Id).HasName("role_id");

            builder.Property(prop => prop.Name)
                .HasColumnName("role_name")
                .HasMaxLength(15)
                .IsRequired();

            builder.Property(prop => prop.Active)
                .HasColumnName("is_active")
                .IsRequired();
        }
    }
}