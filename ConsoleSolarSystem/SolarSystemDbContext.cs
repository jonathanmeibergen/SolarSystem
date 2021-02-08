using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using SolarSystem;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolarSystem
{
    class SolarSystemDbContext : DbContext
    {
        public DbSet<Star> Stars { get; set; }
        public DbSet<Planet> Planets { get; set; }
        public DbSet<Moon> Moons { get; set; }

        public SolarSystemDbContext(): base()
        {

        }

        public SolarSystemDbContext(DbContextOptions<SolarSystemDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured is not true)
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SolarSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Trusted_Connection=True;",
                                            b => b.MigrationsAssembly("ConsoleSolarSystem"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Planet>()
                        .HasOne<Star>(p => p.Star)
                        .WithMany(s => s.Planets)
                        .HasForeignKey(p => p.StarId);

            modelBuilder.Entity<Planet>()
                        .Property(p => p.PlanetType)
                        .HasConversion<int>();

            modelBuilder.Entity<Star>().HasData(new Star
            {
                Id = 1,
                Name = "The Sun",
                Age = "4,600,000,000",
                Diameter = "1,392,684",
                SurfaceTemperature = "5,500",
                CoreTemperature = "15,000,000" 
            });

            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 1,
                Name = "Mercury",
                PlanetType = PlanetTypes.Planet,
                NumberOfMoons = 0,
                Diameter = "4,879",
                OrbitDistance = "57,900,000",
                OrbitPeriod = "88",
                SurfaceTemperatureMin = "472",
                SurfaceTemperatureMax = "-173",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 2,
                Name = "Venus",
                PlanetType = PlanetTypes.Planet,
                NumberOfMoons = 0,
                Diameter = "12,104",
                OrbitDistance = "108,200,000",
                OrbitPeriod = "224.7",
                SurfaceTemperatureMin = "462",
                SurfaceTemperatureMax = "",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 3,
                Name = "Earth",
                PlanetType = PlanetTypes.Planet,
                NumberOfMoons = 1,
                Diameter = "12,756",
                OrbitDistance = "149,600,000",
                OrbitPeriod = "365.2",
                SurfaceTemperatureMin = "-88",
                SurfaceTemperatureMax = "58",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 4,
                Name = "Mars",
                PlanetType = PlanetTypes.Planet,
                NumberOfMoons = 2,
                Diameter = "12,104",
                OrbitDistance = "227,900,000",
                OrbitPeriod = "693.88",
                SurfaceTemperatureMin = "-63",
                SurfaceTemperatureMax = "",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 5,
                Name = "Ceres",
                PlanetType = PlanetTypes.DwarfPlanet,
                NumberOfMoons = 0,
                Diameter = "950",
                OrbitDistance = "413,700,000",
                OrbitPeriod = "1,679.92",
                SurfaceTemperatureMin = "-105",
                SurfaceTemperatureMax = "",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 6,
                Name = "Jupiter",
                PlanetType = PlanetTypes.Planet,
                NumberOfMoons = 67,
                Diameter = "142,984",
                OrbitDistance = "778,300,000",
                OrbitPeriod = "4,345.88",
                SurfaceTemperatureMin = "-108",
                SurfaceTemperatureMax = "",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 7,
                Name = "Saturn",
                PlanetType = PlanetTypes.Planet,
                NumberOfMoons = 62,
                Diameter = "120,536",
                OrbitDistance = "1,400,000,000",
                OrbitPeriod = "20,469.46",
                SurfaceTemperatureMin = "-139",
                SurfaceTemperatureMax = "",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 8,
                Name = "Uranus",
                PlanetType = PlanetTypes.Planet,
                NumberOfMoons = 27,
                Diameter = "51,118",
                OrbitDistance = "2,900,000,000",
                OrbitPeriod = "30,676.8",
                SurfaceTemperatureMin = "-197",
                SurfaceTemperatureMax = "",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 9,
                Name = "Neptune",
                PlanetType = PlanetTypes.Planet,
                NumberOfMoons = 14,
                Diameter = "49,528",
                OrbitDistance = "4,500,000,000",
                OrbitPeriod = "60,184.96",
                SurfaceTemperatureMin = "-201",
                SurfaceTemperatureMax = "",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 10,
                Name = "Pluto",
                PlanetType = PlanetTypes.DwarfPlanet,
                NumberOfMoons = 5,
                Diameter = "2,306",
                OrbitDistance = "5,900,000,000",
                OrbitPeriod = "89,839.2",
                SurfaceTemperatureMin = "-229",
                SurfaceTemperatureMax = "",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 11,
                Name = "Haumea",
                PlanetType = PlanetTypes.DwarfPlanet,
                NumberOfMoons = 2,
                Diameter = "1,518",
                OrbitDistance = "6,400,000,000",
                OrbitPeriod = "103,461.16",
                SurfaceTemperatureMin = "-241",
                SurfaceTemperatureMax = "",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 12,
                Name = "Makemake",
                PlanetType = PlanetTypes.DwarfPlanet,
                NumberOfMoons = 0,
                Diameter = "1,434",
                OrbitDistance = "6,900,000,000",
                OrbitPeriod = "113,175.48",
                SurfaceTemperatureMin = "-239",
                SurfaceTemperatureMax = "",
                StarId = 1
            });
            modelBuilder.Entity<Planet>().HasData(new Planet
            {
                Id = 13,
                Name = "Eris",
                PlanetType = PlanetTypes.DwarfPlanet,
                NumberOfMoons = 1,
                Diameter = "2,326",
                OrbitDistance = "10,100,000,000",
                OrbitPeriod = "204,840.68",
                SurfaceTemperatureMin = "-231",
                SurfaceTemperatureMax = "",
                StarId = 1
            });

        }
    }
}
