using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using SolarSystem.Extensions;

namespace SolarSystem
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlanetTypes PlanetType { get; set; }
        public string Diameter { get; set; }
        public string OrbitDistance { get; set; }
        public string OrbitPeriod { get; set; }
        public string SurfaceTemperatureMin { get; set; } 
        public string SurfaceTemperatureMax { get; set; }

        public double SurfaceTemperature
        {
            get
            {
                if (SurfaceTemperatureMax.Equals(String.Empty))
                    return Convert.ToDouble(SurfaceTemperatureMin.TrimThousands());
                else
                    return Convert.ToDouble(SurfaceTemperatureMin.TrimThousands()) + Convert.ToDouble(SurfaceTemperatureMax.TrimThousands()) / 2;
            } 
        }
        public int NumberOfMoons { get; set; }
        public int StarId { get; set; }
        public Star Star { get; set; }
        public ICollection<Moon> Moons { get; set; }
    }
}
