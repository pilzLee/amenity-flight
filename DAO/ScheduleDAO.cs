using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ScheduleDAO
    {
        AmonicDataContext dt = new AmonicDataContext();
        public Schedules aSchedule(int id)
        {

            Schedules s = new Schedules();
            var query = from sc in dt.Schedules
                        where sc.ID == id
                        select sc;
            foreach(var schedule in query)
            {
                s.ID = schedule.ID;
                s.date = schedule.Date;
                s.time = schedule.Time.ToString();
                s.aircraftID = schedule.AircraftID;
                s.routeID = schedule.RouteID;
                s.economyPrice = schedule.EconomyPrice;
                s.confirmed = schedule.Confirmed;
                s.flightNumber = schedule.FlightNumber;
                s.departure = schedule.Route.Airport.Country.Name;
                s.arrival = schedule.Route.Airport1.Country.Name;
            }
            return s;
        }
        public Schedules getFlight(string flightNumber)
        {

            Schedules s = new Schedules();
            var query = from sc in dt.Schedules
                        where sc.FlightNumber == flightNumber
                        select sc;
            foreach (var schedule in query)
            {
                s.ID = schedule.ID;
                s.date = schedule.Date;
                s.time = schedule.Time.ToString();
                s.aircraftID = schedule.AircraftID;
                s.routeID = schedule.RouteID;
                s.economyPrice = schedule.EconomyPrice;
                s.confirmed = schedule.Confirmed;
                s.flightNumber = schedule.FlightNumber;
                s.departure = schedule.Route.Airport.Country.Name;
                s.arrival = schedule.Route.Airport1.Country.Name;
            }
            return s;
        }
    }
}
