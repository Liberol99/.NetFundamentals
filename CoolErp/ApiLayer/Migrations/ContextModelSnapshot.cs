﻿// <auto-generated />
using ApiLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ApiLayer.Models.Accounting", b =>
                {
                    b.Property<int>("AccountingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Alacak")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Bakiye")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Borc")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HesapAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountingId");

                    b.ToTable("Accountings");
                });
#pragma warning restore 612, 618
        }
    }
}
