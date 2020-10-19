using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsBlazorAPI.Models
{


    public class PlanetList
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public Planet[] Results { get; set; }
    }
}
