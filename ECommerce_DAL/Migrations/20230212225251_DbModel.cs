using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerceDAL.Migrations
{
    /// <inheritdoc />
    public partial class DbModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandname = table.Column<string>(name: "brand_name", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    branddescription = table.Column<string>(name: "brand_description", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    registerdate = table.Column<DateTime>(name: "register_date", type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("brand_id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryname = table.Column<string>(name: "category_name", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    categorydescription = table.Column<string>(name: "category_description", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    registerdate = table.Column<DateTime>(name: "register_date", type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("category_id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("department_id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_permissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    permissionname = table.Column<string>(name: "permission_name", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    permissionroute = table.Column<string>(name: "permission_route", type: "nvarchar(30)", maxLength: 30, nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("permission_id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rolename = table.Column<string>(name: "role_name", type: "nvarchar(15)", maxLength: 15, nullable: false),
                    isactive = table.Column<bool>(name: "is_active", type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("role_id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("transaction_id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    names = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    lastnames = table.Column<string>(name: "last_names", type: "nvarchar(40)", maxLength: 40, nullable: false),
                    dni = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    cellphone = table.Column<int>(name: "cell_phone", type: "int", maxLength: 9, nullable: false),
                    email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registerdate = table.Column<DateTime>(name: "register_date", type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("user_id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_subcategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryid = table.Column<int>(name: "category_id", type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registerdate = table.Column<DateTime>(name: "register_date", type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("subcategory_id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_subcategories_tb_category_category_id",
                        column: x => x.categoryid,
                        principalTable: "tb_category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    departmentid = table.Column<int>(name: "department_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("provimce_id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_provinces_tb_departments_department_id",
                        column: x => x.departmentid,
                        principalTable: "tb_departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PermissionRole",
                columns: table => new
                {
                    PermissionsId = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionRole", x => new { x.PermissionsId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_PermissionRole_tb_permissions_PermissionsId",
                        column: x => x.PermissionsId,
                        principalTable: "tb_permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissionRole_tb_roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "tb_roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_role_has_permission",
                columns: table => new
                {
                    roleid = table.Column<int>(name: "role_id", type: "int", nullable: false),
                    permissionid = table.Column<int>(name: "permission_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_role_has_permission", x => new { x.roleid, x.permissionid });
                    table.ForeignKey(
                        name: "FK_tb_role_has_permission_tb_permissions_permission_id",
                        column: x => x.permissionid,
                        principalTable: "tb_permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_role_has_permission_tb_roles_role_id",
                        column: x => x.roleid,
                        principalTable: "tb_roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_tb_roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "tb_roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_tb_users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "tb_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_user_has_role",
                columns: table => new
                {
                    userid = table.Column<int>(name: "user_id", type: "int", nullable: false),
                    roleid = table.Column<int>(name: "role_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_user_has_role", x => new { x.userid, x.roleid });
                    table.ForeignKey(
                        name: "FK_tb_user_has_role_tb_roles_role_id",
                        column: x => x.roleid,
                        principalTable: "tb_roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_user_has_role_tb_users_user_id",
                        column: x => x.userid,
                        principalTable: "tb_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productname = table.Column<string>(name: "product_name", type: "nvarchar(30)", maxLength: 30, nullable: false),
                    productdescription = table.Column<string>(name: "product_description", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    productprice = table.Column<decimal>(name: "product_price", type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    productstock = table.Column<int>(name: "product_stock", type: "int", nullable: false),
                    subcategoryid = table.Column<int>(name: "subcategory_id", type: "int", nullable: false),
                    registerdate = table.Column<DateTime>(name: "register_date", type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("product_id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_products_tb_subcategories_subcategory_id",
                        column: x => x.subcategoryid,
                        principalTable: "tb_subcategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    districtdescription = table.Column<string>(name: "district_description", type: "nvarchar(30)", maxLength: 30, nullable: false),
                    provinceid = table.Column<int>(name: "province_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("district_id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_districts_tb_provinces_province_id",
                        column: x => x.provinceid,
                        principalTable: "tb_provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productid = table.Column<int>(name: "product_id", type: "int", nullable: false),
                    imageroute = table.Column<string>(name: "image_route", type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("image_id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_images_tb_products_product_id",
                        column: x => x.productid,
                        principalTable: "tb_products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_product_brand",
                columns: table => new
                {
                    brandid = table.Column<int>(name: "brand_id", type: "int", nullable: false),
                    productid = table.Column<int>(name: "product_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_product_brand", x => new { x.brandid, x.productid });
                    table.ForeignKey(
                        name: "FK_tb_product_brand_tb_brands_brand_id",
                        column: x => x.brandid,
                        principalTable: "tb_brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_product_brand_tb_products_product_id",
                        column: x => x.productid,
                        principalTable: "tb_products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transactionid = table.Column<int>(name: "transaction_id", type: "int", nullable: false),
                    orderstate = table.Column<bool>(name: "order_state", type: "bit", nullable: false),
                    userid = table.Column<int>(name: "user_id", type: "int", nullable: false),
                    registerdate = table.Column<DateTime>(name: "register_date", type: "date", nullable: false),
                    orderaddress = table.Column<string>(name: "order_address", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    districtid = table.Column<int>(name: "district_id", type: "int", nullable: false),
                    totalamount = table.Column<decimal>(name: "total_amount", type: "decimal(9,2)", precision: 9, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("order_id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_orders_tb_districts_district_id",
                        column: x => x.districtid,
                        principalTable: "tb_districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_orders_tb_transactions_transaction_id",
                        column: x => x.transactionid,
                        principalTable: "tb_transactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_orders_tb_users_user_id",
                        column: x => x.userid,
                        principalTable: "tb_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_order_details",
                columns: table => new
                {
                    orderid = table.Column<int>(name: "order_id", type: "int", nullable: false),
                    productid = table.Column<int>(name: "product_id", type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_order_details", x => new { x.orderid, x.productid });
                    table.ForeignKey(
                        name: "FK_tb_order_details_tb_orders_order_id",
                        column: x => x.orderid,
                        principalTable: "tb_orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_order_details_tb_products_product_id",
                        column: x => x.productid,
                        principalTable: "tb_products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRole_RolesId",
                table: "PermissionRole",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_districts_province_id",
                table: "tb_districts",
                column: "province_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_images_product_id",
                table: "tb_images",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_order_details_product_id",
                table: "tb_order_details",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_orders_district_id",
                table: "tb_orders",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_orders_transaction_id",
                table: "tb_orders",
                column: "transaction_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_orders_user_id",
                table: "tb_orders",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_product_brand_product_id",
                table: "tb_product_brand",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_products_subcategory_id",
                table: "tb_products",
                column: "subcategory_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_provinces_department_id",
                table: "tb_provinces",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_role_has_permission_permission_id",
                table: "tb_role_has_permission",
                column: "permission_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_subcategories_category_id",
                table: "tb_subcategories",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_user_has_role_role_id",
                table: "tb_user_has_role",
                column: "role_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermissionRole");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "tb_images");

            migrationBuilder.DropTable(
                name: "tb_order_details");

            migrationBuilder.DropTable(
                name: "tb_product_brand");

            migrationBuilder.DropTable(
                name: "tb_role_has_permission");

            migrationBuilder.DropTable(
                name: "tb_user_has_role");

            migrationBuilder.DropTable(
                name: "tb_orders");

            migrationBuilder.DropTable(
                name: "tb_brands");

            migrationBuilder.DropTable(
                name: "tb_products");

            migrationBuilder.DropTable(
                name: "tb_permissions");

            migrationBuilder.DropTable(
                name: "tb_roles");

            migrationBuilder.DropTable(
                name: "tb_districts");

            migrationBuilder.DropTable(
                name: "tb_transactions");

            migrationBuilder.DropTable(
                name: "tb_users");

            migrationBuilder.DropTable(
                name: "tb_subcategories");

            migrationBuilder.DropTable(
                name: "tb_provinces");

            migrationBuilder.DropTable(
                name: "tb_category");

            migrationBuilder.DropTable(
                name: "tb_departments");
        }
    }
}
