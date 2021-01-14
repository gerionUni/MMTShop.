﻿// <auto-generated />
using MMTShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MMTShop.Migrations
{
    [DbContext(typeof(MMTShopContext))]
    [Migration("20210114095224_First_Version")]
    partial class First_Version
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("MMTShop.MMTProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SKU")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryName");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MMTShop.MMTProductCategory", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            Name = "Home"
                        },
                        new
                        {
                            Name = "Garden"
                        },
                        new
                        {
                            Name = "Electronics"
                        },
                        new
                        {
                            Name = "Fitness"
                        },
                        new
                        {
                            Name = "Toys"
                        });
                });

            modelBuilder.Entity("MMTShop.MMTProduct", b =>
                {
                    b.HasOne("MMTShop.MMTProductCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryName");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}