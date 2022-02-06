﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleDatabase.Models;

namespace VehicleDatabase.Migrations
{
    [DbContext(typeof(VehicleDbContext))]
    [Migration("20220206142911_More_Tabels_Added")]
    partial class More_Tabels_Added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleDatabase.Models.Brand", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brand");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            BrandName = "Volvo"
                        },
                        new
                        {
                            Id = 2L,
                            BrandName = "BMW"
                        },
                        new
                        {
                            Id = 3L,
                            BrandName = "Opel"
                        });
                });

            modelBuilder.Entity("VehicleDatabase.Models.Color", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ColorName = "Red"
                        },
                        new
                        {
                            Id = 2L,
                            ColorName = "Green"
                        },
                        new
                        {
                            Id = 3L,
                            ColorName = "Blue"
                        });
                });

            modelBuilder.Entity("VehicleDatabase.Models.Equipment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EquipmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Equipment");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            EquipmentName = "Sunroof"
                        },
                        new
                        {
                            Id = 2L,
                            EquipmentName = "Power Tailgate"
                        },
                        new
                        {
                            Id = 3L,
                            EquipmentName = "4WD"
                        });
                });

            modelBuilder.Entity("VehicleDatabase.Models.Fuel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FuelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fuel");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            FuelName = "95"
                        },
                        new
                        {
                            Id = 2L,
                            FuelName = "98"
                        },
                        new
                        {
                            Id = 3L,
                            FuelName = "Diesel"
                        });
                });

            modelBuilder.Entity("VehicleDatabase.Models.Vehicle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("FuelId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIN")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            BrandId = 1,
                            ColorId = 1,
                            EquipmentId = 1,
                            FuelId = 3,
                            ModelName = "XC90",
                            PlateNumber = "BIL001",
                            VIN = " YV1AA8843M1345789"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}