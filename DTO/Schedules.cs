using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Schedules
    {
        public int ID { get; set; }
        public DateTime date { get; set; }
        public string time { get; set; }
        public int aircraftID { get; set; }
        public int routeID { get; set; }
        public decimal economyPrice { get; set; }
        public bool confirmed { get; set; }
        public string flightNumber { get; set; }
        public string departure { get; set; }
        public string arrival { get; set; }
        public Schedules() { }
    }
}
