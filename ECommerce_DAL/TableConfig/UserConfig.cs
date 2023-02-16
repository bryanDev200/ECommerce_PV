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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable(name: "tb_users");

            builder.HasKey(x => x.Id)
                .HasName("user_id");

            builder.Property(prop => prop.Name)
                .HasColumnName("names")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(prop => prop.LastNames)
                .HasColumnName("last_names")
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(prop => prop.Dni)
                .HasColumnName("dni")
                .HasMaxLength(8)
                .IsRequired();

            builder.Property(prop => prop.CellPhone)
                .HasColumnName("cell_phone")
                .HasMaxLength(9)
                .IsRequired();

            builder.Property(prop => prop.Email)
                .HasColumnName("email")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(prop => prop.UserName)
                .HasColumnName("username")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(prop => prop.Password)
                .HasColumnName("password")
                .IsRequired();

            builder.Property(prop => prop.RegisterDate)
                .HasColumnName("register_date")
                .HasColumnType("date")
                .IsRequired();
        }
    }
}