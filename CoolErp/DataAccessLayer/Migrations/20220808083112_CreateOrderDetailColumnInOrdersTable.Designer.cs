﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220808083112_CreateOrderDetailColumnInOrdersTable")]
    partial class CreateOrderDetailColumnInOrdersTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("EntityLayer.Concrete.Bank", b =>
                {
                    b.Property<int>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CVV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameOnCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BankId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipRegion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipVia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShipperId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ShipperId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EntityLayer.Concrete.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Discounted")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityPerUnit")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitsInCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.Property<int>("UnitsOnOrder")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Shipper", b =>
                {
                    b.Property<int>("ShipperId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShipperId");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bank", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Customer", "Customer")
                        .WithMany("Bank")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Order", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Employee", "Employee")
                        .WithMany("Order")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Shipper", "Shipper")
                        .WithMany("Order")
                        .HasForeignKey("ShipperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("EntityLayer.Concrete.OrderDetail", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Order", "Order")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Product", "Product")
                        .WithMany("OrderDetail")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Supplier", "Supplier")
                        .WithMany("Product")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Category", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Customer", b =>
                {
                    b.Navigation("Bank");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Employee", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Order", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Product", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Shipper", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Supplier", b =>
                {
                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
