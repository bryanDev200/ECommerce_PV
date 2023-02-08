using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BRYAN418\\SQLEXPRESS; database=Negocios2022; Trusted_Connection=False; uid= sa; pwd= sql; MultipleActiveResultSets=True; TrustServerCertificate=False;Encrypt=False");
        }
    }
}