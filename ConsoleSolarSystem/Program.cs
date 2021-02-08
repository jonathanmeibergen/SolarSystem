using SolarSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using SolarSystem.Extensions;

namespace ConsoleSolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SolarSystemDbContext ct = new SolarSystemDbContext();

            //PrintList(OrderByAmountOfMoonsOfDwarfPlanets(ct), p => $"{p.Name} has {p.NumberOfMoons} moon(s).");
            //PrintList(OrderByOrbitalDistance(ct), p => $"{p.Name} has an orbital distance of {p.OrbitDistance} km.");
            //Console.WriteLine($"There are {AmountOfMoonsSolarSystem(ct)} moons in the solar system.");
            //PrintList(OrderDwarfPlanetsByDiameter(ct), dp => $"{dp.Name} has a diameter of {dp.Diameter} km");
            //Console.WriteLine($"{AverageAmountOfMoonsPerDwarfPlanet(ct)} moons per dwarf planet");
            PrintList(AverageSurfaceTemperaturesPerTypeOfObject(ct), d => d);

        }

        private static List<Planet> TwoClosestPlanets(SolarSystemDbContext ct)
        {
            List<Planet> planets = ct.Planets.Min(p => Convert.ToDouble(p.OrbitDistance.TrimThousands()))

            return
        }
        private static List<string> AverageSurfaceTemperaturesPerTypeOfObject(SolarSystemDbContext ct)
        {
            List<Planet> dwarfPlanets = ct.Planets.Where(p => p.PlanetType == PlanetTypes.DwarfPlanet)
                                                  .ToList();
            List<Planet> planets = ct.Planets.Where(p => p.PlanetType == PlanetTypes.Planet)
                                             .ToList();
            Star sun = ct.Stars.FirstOrDefault(s => s.Name.Equals("The Sun"));//, StringComparison.Ordinal));
            List<string> display = new List<string>();

            double dwarfAverage = dwarfPlanets.Average(dp => dp.SurfaceTemperature);
            double planetAverage = planets.Average(p => p.SurfaceTemperature);

            display.Add($"The average surface temperature of all Dwarf Planets is {dwarfAverage} degree celsius");
            display.Add($"The average surface temperature of all Planets is {planetAverage} degree celsius");
            display.Add($"The average surface temperature of the Sun is {sun.SurfaceTemperature.TrimThousands()} degree celsius");

            return display;
        }

        private static float AverageAmountOfMoonsPerDwarfPlanet(SolarSystemDbContext ct)
        {
            List<Planet> dwarfPlanets = ct.Planets.Where(p => p.PlanetType == PlanetTypes.DwarfPlanet).ToList();
            return Convert.ToInt32(dwarfPlanets.Average(dp => dp.NumberOfMoons));
        }

        private static List<Planet> OrderDwarfPlanetsByDiameter(SolarSystemDbContext ct)
        {
            return ct.Planets.Where(p => p.PlanetType == PlanetTypes.DwarfPlanet)
                .OrderByDescending(dp => Convert.ToInt64(dp.Diameter.Replace(",",""))).ToList();
        }

        private static int AmountOfMoonsSolarSystem(SolarSystemDbContext ct)
        {
            return ct.Planets.Sum(p => p.NumberOfMoons);
        }

        private static List<Planet> OrderByAmountOfMoonsOfDwarfPlanets(SolarSystemDbContext ct)
        {
            return ct.Planets.Where(p => p.PlanetType == PlanetTypes.DwarfPlanet)
                             .OrderByDescending(p => p.NumberOfMoons).ToList();
        }

        private static List<Planet> OrderByOrbitalDistance(SolarSystemDbContext ct)
        {
            return ct.Planets.OrderBy(p => Convert.ToInt64(p.OrbitDistance.Replace(",",""))).ToList();
        }

        private static List<Planet> OrderByPlanetNameLength(SolarSystemDbContext ct)
        {
            return ct.Planets.OrderByDescending(p => p.Name.Length).ToList();
        }

        private static List<Planet> PlanetNameWithPandT(SolarSystemDbContext ct)
        {
            return ct.Planets.Where(p => p.Name.Contains("P") && p.Name.Contains("T")).ToList();
        }

        private static List<Planet> AboveZeroDegrees(SolarSystemDbContext ct)
        {
            return ct.Planets.Where(p => Convert.ToInt32(p.SurfaceTemperatureMax) > 0 || Convert.ToInt32(p.SurfaceTemperatureMin) > 0).ToList();
        }

        private static List<Planet> OrderPlanetsByNameAscending(SolarSystemDbContext ct)
        {
            return ct.Planets.OrderBy(p => p.Name).ToList();
        }

        private static void PrintList<T>(List<T> list, Func<T,string> display)
        {
            if (list is not null)
            {
                foreach (T item in list)
                {
                    Console.WriteLine(display(item));
                }
            } else
            {
                Console.WriteLine("There are no items to display.");
            }
        }
    }
}
