using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem.Extensions
{
    public static class StringExtensions
    {
        public static string TrimThousands(this String str){
            return str.Replace(",", "");
        }
    }
}
