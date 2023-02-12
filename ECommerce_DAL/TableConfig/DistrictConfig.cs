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
    public class DistrictConfig : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable(name: "tb_districts");

            builder.HasKey(prop => prop.Id).HasName("district_id");

            builder.Property(prop => prop.Description)
                .HasColumnName("district_description")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(prop => prop.ProvinceId)
                .HasColumnName("province_id");
        }
    }
}