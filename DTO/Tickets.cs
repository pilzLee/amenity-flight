using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tickets
    {
        public int ID { get; set; }
        public int userID { get; set; }
        public int scheduleID { get; set; }
        public int cabinTypeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string passportNumber { get; set; }
        public int passportCountryID { get; set; }
        public string bookingReference { get; set; }
        public bool confirmed { get; set; }
        public Tickets() { }
    }
}
