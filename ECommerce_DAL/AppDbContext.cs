using ECommerce_EntityL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrdersDetail { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<UserRole> UserHasRoles { get; set; }
        public DbSet<RolePermission> RoleHasPermissions { get; set; }
    }
}