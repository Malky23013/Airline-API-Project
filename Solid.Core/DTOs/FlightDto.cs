using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class FlightDto
    {
        public int Id { get; private set; }
        public static int id { private get; set; }
        public string Company { get; set; }
        public string Destination { get; set; }
        public string Source { get; set; }
    }
}
