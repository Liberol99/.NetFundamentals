using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoolSales.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustStreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpStreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpAreaCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpBirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuotedPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantityOrdered = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<int>(type: "int", nullable: false),
                    ProductDescription = table.Column<int>(type: "int", nullable: false),
                    RetailPrice = table.Column<int>(type: "int", nullable: false),
                    QuantityOnHand = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendStreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendFaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendWebPage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
