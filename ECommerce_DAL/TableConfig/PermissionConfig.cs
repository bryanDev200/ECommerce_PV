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
    public class PermissionConfig : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable(name: "tb_permissions");

            builder.HasKey(prop => prop.Id).HasName("permission_id");

            builder.Property(prop => prop.Name)
                .HasColumnName("permission_name")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(prop => prop.Route)
                .HasColumnName("permission_route")
                .HasMaxLength(30)
                .IsRequired();


            builder.Property(prop => prop.Active)
                .HasColumnName("is_active")
                .IsRequired();
        }
    }
}