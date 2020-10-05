﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ContextObl))]
    [Migration("20201001203247_migrationAgus2")]
    partial class migrationAgus2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Domain.CategoryTouristSpot", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TouristSpotId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoryId", "TouristSpotId");

                    b.HasIndex("TouristSpotId");

                    b.ToTable("CategoriesTouristSpots");
                });

            modelBuilder.Entity("Domain.Lodging", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Images")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("float");

                    b.Property<int>("QuantityOfStars")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<Guid?>("TouristSpotId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TouristSpotId");

                    b.ToTable("Lodgings");
                });

            modelBuilder.Entity("Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Domain.Reserve", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionForGuest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LodgingOfReserveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumberOfContact")
                        .HasColumnType("int");

                    b.Property<int>("QuantityOfAdult")
                        .HasColumnType("int");

                    b.Property<int>("QuantityOfBaby")
                        .HasColumnType("int");

                    b.Property<int>("QuantityOfChild")
                        .HasColumnType("int");

                    b.Property<int>("StateOfReserve")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LodgingOfReserveId");

                    b.ToTable("Reserves");
                });

            modelBuilder.Entity("Domain.TouristSpot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("TouristSpots");
                });

            modelBuilder.Entity("Domain.CategoryTouristSpot", b =>
                {
                    b.HasOne("Domain.Category", "Category")
                        .WithMany("ListOfTouristSpot")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.TouristSpot", "TouristSpot")
                        .WithMany("ListOfCategories")
                        .HasForeignKey("TouristSpotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Lodging", b =>
                {
                    b.HasOne("Domain.TouristSpot", "TouristSpot")
                        .WithMany()
                        .HasForeignKey("TouristSpotId");
                });

            modelBuilder.Entity("Domain.Reserve", b =>
                {
                    b.HasOne("Domain.Lodging", "LodgingOfReserve")
                        .WithMany()
                        .HasForeignKey("LodgingOfReserveId");
                });

            modelBuilder.Entity("Domain.TouristSpot", b =>
                {
                    b.HasOne("Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId");
                });
#pragma warning restore 612, 618
        }
    }
}
