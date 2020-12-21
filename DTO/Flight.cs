using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Flight
    {
        public int flightID { get; set; }
        public string flightNumber { get; set; }
        public string flightPlace { get; set; }
        public string flightDate { get; set; }
        public string flightTime { get; set; }
        public Flight() { }
    }
}
