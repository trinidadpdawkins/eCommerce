﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MisterRobotoArigato.Data;

namespace MisterRobotoArigato.Migrations.RobotoDb
{
    [DbContext(typeof(RobotoDbContext))]
    [Migration("20180717060644_tweth")]
    partial class tweth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MisterRobotoArigato.Models.Basket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerID");

                    b.HasKey("ID");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("MisterRobotoArigato.Models.BasketDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerID");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("ID");

                    b.ToTable("BasketDetails");
                });

            modelBuilder.Entity("MisterRobotoArigato.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BasketID");

                    b.Property<string>("Description");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<string>("SKU")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("BasketID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MisterRobotoArigato.Models.Product", b =>
                {
                    b.HasOne("MisterRobotoArigato.Models.Basket")
                        .WithMany("Products")
                        .HasForeignKey("BasketID");
                });
#pragma warning restore 612, 618
        }
    }
}
