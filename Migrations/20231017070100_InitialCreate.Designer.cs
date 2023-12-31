﻿// <auto-generated />
using FirstProductsAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstProductsAPI.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20231017070100_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("FirstProductsAPI.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            IsActive = true,
                            Price = 6000m,
                            ProductName = "Iphone 14"
                        },
                        new
                        {
                            ProductId = 2,
                            IsActive = true,
                            Price = 7000m,
                            ProductName = "Iphone 15"
                        },
                        new
                        {
                            ProductId = 3,
                            IsActive = true,
                            Price = 8000m,
                            ProductName = "Iphone 16"
                        },
                        new
                        {
                            ProductId = 4,
                            IsActive = false,
                            Price = 9000m,
                            ProductName = "Iphone 17"
                        },
                        new
                        {
                            ProductId = 5,
                            IsActive = true,
                            Price = 9500m,
                            ProductName = "Iphone 18"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
