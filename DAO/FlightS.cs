using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class FlightS
    {
        AmonicDataContext dt = new AmonicDataContext();
        public List<Flight> flights(string bookingReference)
        {
            List<Flight> list = new List<Flight>();
            var query = from t in dt.Tickets
                        where (t.BookingReference == bookingReference)
                        select t;
            foreach(var ticket in query)
            {
                Flight f = new Flight();
                f.flightID = ticket.ID;
                f.flightNumber = ticket.Schedule.FlightNumber;
                f.flightPlace = ticket.Schedule.Route.Airport.IATACode + "-"
                    + ticket.Schedule.Route.Airport1.IATACode;
                f.flightDate = ticket.Schedule.Date.ToShortDateString().ToString();
                f.flightTime = ticket.Schedule.Time.ToString();
                list.Add(f);
            }
            return list;
        }
        
    }
}
