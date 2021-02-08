using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    public class Star
    {
        //uint Diameter;
        //ulong Age;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Diameter { get; set; }
        public string Age { get; set; }
        public string SurfaceTemperature { get; set; }
        public string CoreTemperature { get; set; }
        public ICollection<Planet> Planets { get; set; }
    }
}
