﻿// <auto-generated />
using System;
using ConsoleSolarSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleSolarSystem.Migrations
{
    [DbContext(typeof(SolarSystemDbContext))]
    [Migration("20210205134351_solar_system_fix5")]
    partial class solar_system_fix5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("SolarSystem.Moon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlanetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanetId");

                    b.ToTable("Moons");
                });

            modelBuilder.Entity("SolarSystem.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Diameter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfMoons")
                        .HasColumnType("int");

                    b.Property<string>("OrbitDistance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrbitPeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlanetType")
                        .HasColumnType("int");

                    b.Property<int>("StarId")
                        .HasColumnType("int");

                    b.Property<string>("SurfaceTemperatureMax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurfaceTemperatureMin")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StarId");

                    b.ToTable("Planets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Diameter = "4,879",
                            Name = "Mercury",
                            NumberOfMoons = 0,
                            OrbitDistance = "57,900,000",
                            OrbitPeriod = "88",
                            PlanetType = 0,
                            StarId = 1,
                            SurfaceTemperatureMax = "-173",
                            SurfaceTemperatureMin = "472"
                        },
                        new
                        {
                            Id = 2,
                            Diameter = "12,104",
                            Name = "Venus",
                            NumberOfMoons = 0,
                            OrbitDistance = "108,200,000",
                            OrbitPeriod = "224.7",
                            PlanetType = 0,
                            StarId = 1,
                            SurfaceTemperatureMax = "",
                            SurfaceTemperatureMin = "462"
                        },
                        new
                        {
                            Id = 3,
                            Diameter = "12,756",
                            Name = "Earth",
                            NumberOfMoons = 1,
                            OrbitDistance = "149,600,000",
                            OrbitPeriod = "365.2",
                            PlanetType = 0,
                            StarId = 1,
                            SurfaceTemperatureMax = "58",
                            SurfaceTemperatureMin = "-88"
                        },
                        new
                        {
                            Id = 4,
                            Diameter = "12,104",
                            Name = "Mars",
                            NumberOfMoons = 2,
                            OrbitDistance = "227,900,000",
                            OrbitPeriod = "693.88",
                            PlanetType = 0,
                            StarId = 1,
                            SurfaceTemperatureMax = "",
                            SurfaceTemperatureMin = "-63"
                        },
                        new
                        {
                            Id = 5,
                            Diameter = "950",
                            Name = "Ceres",
                            NumberOfMoons = 0,
                            OrbitDistance = "413,700,000",
                            OrbitPeriod = "1,679.92",
                            PlanetType = 1,
                            StarId = 1,
                            SurfaceTemperatureMax = "",
                            SurfaceTemperatureMin = "-105"
                        },
                        new
                        {
                            Id = 6,
                            Diameter = "142,984",
                            Name = "Jupiter",
                            NumberOfMoons = 67,
                            OrbitDistance = "778,300,000",
                            OrbitPeriod = "4,345.88",
                            PlanetType = 0,
                            StarId = 1,
                            SurfaceTemperatureMax = "",
                            SurfaceTemperatureMin = "-108"
                        },
                        new
                        {
                            Id = 7,
                            Diameter = "120,536",
                            Name = "Saturn",
                            NumberOfMoons = 62,
                            OrbitDistance = "1,400,000,000",
                            OrbitPeriod = "20,469.46",
                            PlanetType = 0,
                            StarId = 1,
                            SurfaceTemperatureMax = "",
                            SurfaceTemperatureMin = "-139"
                        },
                        new
                        {
                            Id = 8,
                            Diameter = "51,118",
                            Name = "Uranus",
                            NumberOfMoons = 27,
                            OrbitDistance = "2,900,000,000",
                            OrbitPeriod = "30,676.8",
                            PlanetType = 0,
                            StarId = 1,
                            SurfaceTemperatureMax = "",
                            SurfaceTemperatureMin = "-197"
                        },
                        new
                        {
                            Id = 9,
                            Diameter = "49,528",
                            Name = "Neptune",
                            NumberOfMoons = 14,
                            OrbitDistance = "4,500,000,000",
                            OrbitPeriod = "60,184.96",
                            PlanetType = 0,
                            StarId = 1,
                            SurfaceTemperatureMax = "",
                            SurfaceTemperatureMin = "-201"
                        },
                        new
                        {
                            Id = 10,
                            Diameter = "2,306",
                            Name = "Pluto",
                            NumberOfMoons = 5,
                            OrbitDistance = "5,900,000,000",
                            OrbitPeriod = "89,839.2",
                            PlanetType = 1,
                            StarId = 1,
                            SurfaceTemperatureMax = "",
                            SurfaceTemperatureMin = "-229"
                        },
                        new
                        {
                            Id = 11,
                            Diameter = "1,518",
                            Name = "Haumea",
                            NumberOfMoons = 2,
                            OrbitDistance = "6,400,000,000",
                            OrbitPeriod = "103,461.16",
                            PlanetType = 1,
                            StarId = 1,
                            SurfaceTemperatureMax = "",
                            SurfaceTemperatureMin = "-241"
                        },
                        new
                        {
                            Id = 12,
                            Diameter = "1,434",
                            Name = "Makemake",
                            NumberOfMoons = 0,
                            OrbitDistance = "6,900,000,000",
                            OrbitPeriod = "113,175.48",
                            PlanetType = 1,
                            StarId = 1,
                            SurfaceTemperatureMax = "",
                            SurfaceTemperatureMin = "-239"
                        },
                        new
                        {
                            Id = 13,
                            Diameter = "2,326",
                            Name = "Eris",
                            NumberOfMoons = 1,
                            OrbitDistance = "10,100,000,000",
                            OrbitPeriod = "204,840.68",
                            PlanetType = 1,
                            StarId = 1,
                            SurfaceTemperatureMax = "",
                            SurfaceTemperatureMin = "-231"
                        });
                });

            modelBuilder.Entity("SolarSystem.Star", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoreTemperature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diameter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurfaceTemperature")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = "4,600,000,000",
                            CoreTemperature = "15,000,000",
                            Diameter = "1,392,684",
                            Name = "The Sun",
                            SurfaceTemperature = "5,500"
                        });
                });

            modelBuilder.Entity("SolarSystem.Moon", b =>
                {
                    b.HasOne("SolarSystem.Planet", null)
                        .WithMany("Moons")
                        .HasForeignKey("PlanetId");
                });

            modelBuilder.Entity("SolarSystem.Planet", b =>
                {
                    b.HasOne("SolarSystem.Star", "Star")
                        .WithMany("Planets")
                        .HasForeignKey("StarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Star");
                });

            modelBuilder.Entity("SolarSystem.Planet", b =>
                {
                    b.Navigation("Moons");
                });

            modelBuilder.Entity("SolarSystem.Star", b =>
                {
                    b.Navigation("Planets");
                });
#pragma warning restore 612, 618
        }
    }
}