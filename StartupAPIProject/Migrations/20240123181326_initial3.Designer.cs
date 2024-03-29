﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StartupAPIProject.Infrastructure.Context;

#nullable disable

namespace StartupAPIProject.Migrations
{
    [DbContext(typeof(StartupDbContext))]
    [Migration("20240123181326_initial3")]
    partial class initial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StartupAPIProject.Infrastructure.EntityModel.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 1, 23, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(1981),
                            Description = "Apple, IOS",
                            Image = "test.jpg",
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 1, 22, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2012),
                            Description = "Samsung, OneUI",
                            Image = "test.jpg",
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 1, 21, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2016),
                            Description = "Redmi",
                            Image = "test.jpg",
                            Name = "Xiaomi"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 1, 20, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2017),
                            Description = "Android",
                            Image = "test.jpg",
                            Name = "Oppo"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 1, 19, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2018),
                            Description = "Android",
                            Image = "test.jpg",
                            Name = "Realme"
                        });
                });

            modelBuilder.Entity("StartupAPIProject.Infrastructure.EntityModel.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PriceUnit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CategoryName = "Apple",
                            CreatedDate = new DateTime(2024, 1, 23, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2114),
                            Description = "Apple, IOS",
                            Image = "product.jpeg",
                            Name = "Apple",
                            Price = 0m,
                            PriceUnit = 0m,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CategoryName = "Samsung",
                            CreatedDate = new DateTime(2024, 1, 22, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2116),
                            Description = "Samsung, OneUI",
                            Image = "product.jpeg",
                            Name = "Samsung",
                            Price = 0m,
                            PriceUnit = 0m,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CategoryName = "Xiaomi",
                            CreatedDate = new DateTime(2024, 1, 21, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2118),
                            Description = "Redmi",
                            Image = "product.jpeg",
                            Name = "Xiaomi",
                            Price = 0m,
                            PriceUnit = 0m,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CategoryName = "Oppo",
                            CreatedDate = new DateTime(2024, 1, 20, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2119),
                            Description = "Android",
                            Image = "product.jpeg",
                            Name = "Oppo",
                            Price = 0m,
                            PriceUnit = 0m,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            CategoryName = "Realme",
                            CreatedDate = new DateTime(2024, 1, 19, 18, 13, 26, 383, DateTimeKind.Utc).AddTicks(2120),
                            Description = "Android",
                            Image = "product.jpeg",
                            Name = "Realme",
                            Price = 0m,
                            PriceUnit = 0m,
                            Quantity = 0
                        });
                });

            modelBuilder.Entity("StartupAPIProject.Infrastructure.EntityModel.Product", b =>
                {
                    b.HasOne("StartupAPIProject.Infrastructure.EntityModel.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("StartupAPIProject.Infrastructure.EntityModel.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
