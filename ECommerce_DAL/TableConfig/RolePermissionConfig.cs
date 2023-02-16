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
    public class RolePermissionConfig : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.ToTable(name: "tb_role_has_permission");

            builder.HasKey(prop => new { prop.RoleId, prop.PermissionId });

            builder.Property(prop => prop.RoleId)
                .HasColumnName("role_id");

            builder.Property(prop => prop.PermissionId)
                .HasColumnName("permission_id");
        }
    }
}