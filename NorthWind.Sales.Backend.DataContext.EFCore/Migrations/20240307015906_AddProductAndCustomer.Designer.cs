﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NorthWind.Sales.Backend.DataContext.EFCore.DataContexts;

#nullable disable

namespace NorthWind.Sales.Backend.DataContext.EFCore.Migrations
{
    [DbContext(typeof(NorthWindContext))]
    [Migration("20240307015906_AddProductAndCustomer")]
    partial class AddProductAndCustomer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NorthWind.Sales.Backend.BusinessObjects.POCOEntities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .IsFixedLength();

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("DiscountType")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("ShipCity")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ShipCountry")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("ShipPostalcode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("ShippingType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("NorthWind.Sales.Backend.Repositories.Entities.Customer", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(5)
                        .HasColumnType("nchar(5)")
                        .IsFixedLength();

                    b.Property<decimal>("CurrentBallance")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = "ALFKI",
                            CurrentBallance = 0m,
                            Name = "Alfreds Futterkiste"
                        },
                        new
                        {
                            Id = "ANATR",
                            CurrentBallance = 0m,
                            Name = "Ana Trujillo"
                        },
                        new
                        {
                            Id = "ANTON",
                            CurrentBallance = 100m,
                            Name = "Antonio Moreno"
                        });
                });

            modelBuilder.Entity("NorthWind.Sales.Backend.Repositories.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("OrderID", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("NorthWind.Sales.Backend.Repositories.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<short>("UnitInStock")
                        .HasColumnType("smallint");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Chai",
                            UnitInStock = (short)20,
                            UnitPrice = 35m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Chang",
                            UnitInStock = (short)0,
                            UnitPrice = 55m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Anised Syrup",
                            UnitInStock = (short)20,
                            UnitPrice = 65m
                        },
                        new
                        {
                            Id = 4,
                            Name = "Chef Anton's",
                            UnitInStock = (short)40,
                            UnitPrice = 75m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Gumbo Mix",
                            UnitInStock = (short)20,
                            UnitPrice = 50m
                        });
                });

            modelBuilder.Entity("NorthWind.Sales.Backend.BusinessObjects.POCOEntities.Order", b =>
                {
                    b.HasOne("NorthWind.Sales.Backend.Repositories.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NorthWind.Sales.Backend.Repositories.Entities.OrderDetail", b =>
                {
                    b.HasOne("NorthWind.Sales.Backend.BusinessObjects.POCOEntities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NorthWind.Sales.Backend.Repositories.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}