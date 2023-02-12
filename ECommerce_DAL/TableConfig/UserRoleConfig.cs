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
    public class UserRoleConfig : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable(name: "tb_user_has_role");

            builder.HasKey(prop => new { prop.UserId, prop.RoleId });

            builder.Property(prop => prop.UserId)
                .HasColumnName("user_id");

            builder.Property(prop => prop.RoleId)
                .HasColumnName("role_id");
        }
    }
}