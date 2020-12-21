using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Routes
    {
        public int ID { get; set; }
        public int departureAirportID { get; set; }
        public int arrivalAirportID { get; set; }
        public int distance { get; set; }
        public int flightTime { get; set; }
        public Routes() { }
    }
}
