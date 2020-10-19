using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsBlazorAPI.Models
{


    public class StarshipList
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public Starship[] Results { get; set; }
    }
}
