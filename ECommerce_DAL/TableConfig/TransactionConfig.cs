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
    public class TransactionConfig : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable(name: "tb_transactions");

            builder.HasKey(prop => prop.Id)
                .HasName("transaction_id");

            builder.Property(prop => prop.Name)
                .HasMaxLength(15)
                .IsRequired();
        }
    }
}