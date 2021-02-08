using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    public class Moon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Diameter { get; set; }
        public int PlanetId { get; set; }
        public Planet Planet { get; set; }
    }
}
