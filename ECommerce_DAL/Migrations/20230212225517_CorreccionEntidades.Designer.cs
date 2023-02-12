﻿// <auto-generated />
using System;
using ECommerce_DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ECommerceDAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230212225517_CorreccionEntidades")]
    partial class CorreccionEntidades
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ECommerce_EntityL.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("brand_description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("brand_name");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("date")
                        .HasColumnName("register_date");

                    b.HasKey("Id")
                        .HasName("brand_id");

                    b.ToTable("tb_brands", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("category_description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("category_name");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("date")
                        .HasColumnName("register_date");

                    b.HasKey("Id")
                        .HasName("category_id");

                    b.ToTable("tb_category", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("description");

                    b.HasKey("Id")
                        .HasName("department_id");

                    b.ToTable("tb_departments", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("district_description");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int")
                        .HasColumnName("province_id");

                    b.HasKey("Id")
                        .HasName("district_id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("tb_districts", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<string>("Route")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("image_route");

                    b.HasKey("Id")
                        .HasName("image_id");

                    b.HasIndex("ProductId");

                    b.ToTable("tb_images", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("order_address");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int")
                        .HasColumnName("district_id");

                    b.Property<bool>("OrderState")
                        .HasColumnType("bit")
                        .HasColumnName("order_state");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("date")
                        .HasColumnName("register_date");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)")
                        .HasColumnName("total_amount");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int")
                        .HasColumnName("transaction_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("order_id");

                    b.HasIndex("DistrictId");

                    b.HasIndex("TransactionId");

                    b.HasIndex("UserId");

                    b.ToTable("tb_orders", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<decimal>("Price")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)")
                        .HasColumnName("price");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("tb_order_details", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("permission_name");

                    b.Property<string>("Route")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("permission_route");

                    b.HasKey("Id")
                        .HasName("permission_id");

                    b.ToTable("tb_permissions", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("product_description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("product_name");

                    b.Property<decimal>("Price")
                        .HasPrecision(9, 2)
                        .HasColumnType("decimal(9,2)")
                        .HasColumnName("product_price");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("date")
                        .HasColumnName("register_date");

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasColumnName("product_stock");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int")
                        .HasColumnName("subcategory_id");

                    b.HasKey("Id")
                        .HasName("product_id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("tb_products", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.ProductBrand", b =>
                {
                    b.Property<int>("BrandId")
                        .HasColumnType("int")
                        .HasColumnName("brand_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.HasKey("BrandId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("tb_product_brand", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("department_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("description");

                    b.HasKey("Id")
                        .HasName("provimce_id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("tb_provinces", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("is_active");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("role_name");

                    b.HasKey("Id")
                        .HasName("role_id");

                    b.ToTable("tb_roles", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.RolePermission", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int")
                        .HasColumnName("permission_id");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("tb_role_has_permission", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Subcategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("date")
                        .HasColumnName("register_date");

                    b.HasKey("Id")
                        .HasName("subcategory_id");

                    b.HasIndex("CategoryId");

                    b.ToTable("tb_subcategories", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id")
                        .HasName("transaction_id");

                    b.ToTable("tb_transactions", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CellPhone")
                        .HasMaxLength(9)
                        .HasColumnType("int")
                        .HasColumnName("cell_phone");

                    b.Property<int>("Dni")
                        .HasMaxLength(8)
                        .HasColumnType("int")
                        .HasColumnName("dni");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("email");

                    b.Property<string>("LastNames")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("last_names");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("names");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("date")
                        .HasColumnName("register_date");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("user_id");

                    b.ToTable("tb_users", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<int>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("tb_user_has_role", (string)null);
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.District", b =>
                {
                    b.HasOne("ECommerce_EntityL.Models.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Image", b =>
                {
                    b.HasOne("ECommerce_EntityL.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Order", b =>
                {
                    b.HasOne("ECommerce_EntityL.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce_EntityL.Models.Transaction", "Transaction")
                        .WithMany("Orders")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce_EntityL.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");

                    b.Navigation("Transaction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.OrderDetail", b =>
                {
                    b.HasOne("ECommerce_EntityL.Models.Order", "Order")
                        .WithMany("Details")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce_EntityL.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Product", b =>
                {
                    b.HasOne("ECommerce_EntityL.Models.Subcategory", "Subcategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subcategory");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.ProductBrand", b =>
                {
                    b.HasOne("ECommerce_EntityL.Models.Brand", "Brand")
                        .WithMany("BrandProducts")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce_EntityL.Models.Product", "Product")
                        .WithMany("ProductsBrand")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Province", b =>
                {
                    b.HasOne("ECommerce_EntityL.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.RolePermission", b =>
                {
                    b.HasOne("ECommerce_EntityL.Models.Permission", "Permission")
                        .WithMany("Roles")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce_EntityL.Models.Role", "Role")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Subcategory", b =>
                {
                    b.HasOne("ECommerce_EntityL.Models.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.UserRole", b =>
                {
                    b.HasOne("ECommerce_EntityL.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ECommerce_EntityL.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Brand", b =>
                {
                    b.Navigation("BrandProducts");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Order", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Permission", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("OrderDetails");

                    b.Navigation("ProductsBrand");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Role", b =>
                {
                    b.Navigation("Permissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.Transaction", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ECommerce_EntityL.Models.User", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}