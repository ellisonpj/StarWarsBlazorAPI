using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsBlazorAPI.Models
{

    public class Movies
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public Films[] Results { get; set; }
    }
}
