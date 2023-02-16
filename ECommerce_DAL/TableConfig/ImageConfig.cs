using ECommerce_EntityL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_DAL.TableConfig
{
    public class ImageConfig : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable(name: "tb_images");

            builder.HasKey(prop => prop.Id).HasName("image_id");

            builder.Property(prop => prop.ProductId)
                .HasColumnName("product_id");

            builder.Property(prop => prop.Route)
                .HasColumnName("image_route")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}