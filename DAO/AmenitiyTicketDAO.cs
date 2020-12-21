using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AmenitiyTicketDAO
    {
        AmonicDataContext dt = new AmonicDataContext();
        public List<AmenitiesTicket> listAmenity(int ID)
        {
            List<AmenitiesTicket> list = new List<AmenitiesTicket>();
            var query = from a in dt.AmenitiesTickets
                        where a.TicketID == ID
                        select a;
            foreach (var amen in query)
            {
                AmenitiesTicket n = new AmenitiesTicket();
                n.TicketID = amen.TicketID;
                n.AmenityID = amen.AmenityID;
                n.Price = amen.Price;
                list.Add(n);
            }
            return list;
        }
        public void insertAmenityTicket(int aID, int tID)
        {
            AmenitiesTicket a = new AmenitiesTicket();
            a.AmenityID = aID;
            a.TicketID = tID;
            dt.AmenitiesTickets.InsertOnSubmit(a);
            dt.SubmitChanges();
        }
        public void deleteAll(int tID)
        {
            //AmenitiesTicket a = dt.AmenitiesTickets.FirstOrDefault(s => s.TicketID == tID);
            //dt.AmenitiesTickets.DeleteOnSubmit(a);
            //dt.SubmitChanges();
            var query = from at in dt.AmenitiesTickets
                        where at.TicketID == tID
                        select at;
            dt.AmenitiesTickets.DeleteAllOnSubmit(query);
            dt.SubmitChanges();
        }
        public void deleteAmenityTicket(int aID, int tID)
        {
            AmenitiesTicket a = dt.AmenitiesTickets.SingleOrDefault(s => s.TicketID == tID && s.AmenityID == aID);
            dt.AmenitiesTickets.DeleteOnSubmit(a);
            dt.SubmitChanges();
        }
        public int getAmount(string flightNumber, string amenityName, int cabinType)
        {
            var query = from a in dt.AmenitiesTickets
                        where a.Ticket.Schedule.FlightNumber == flightNumber
                        && a.Amenity.Service == amenityName
                        && a.Ticket.CabinTypeID == cabinType
                        select a;
            return query.Count();
        }
    }
}
