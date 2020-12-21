using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class TicketsDAO
    {
        AmonicDataContext dt = new AmonicDataContext();
        public Ticket aTicket(int ID)
        {
            Ticket a = new Ticket();
            var query = from t in dt.Tickets
                        where t.ID == ID
                        select t;
            foreach(var ticket in query) 
            { 
                a.ID = ticket.ID;
                a.UserID = ticket.UserID;
                a.ScheduleID = ticket.ScheduleID;
                a.CabinTypeID = ticket.CabinTypeID;
                a.Firstname = ticket.Firstname;
                a.Lastname = ticket.Lastname;
                a.Phone = ticket.Phone;
                a.PassportNumber = ticket.PassportNumber;
                a.PassportCountryID = ticket.PassportCountryID;
                a.BookingReference = ticket.BookingReference;
                a.Confirmed = ticket.Confirmed;
            }
            return a;
            
        }
        public List<Tickets> listTicket()
        {
            List<Tickets> list = new List<Tickets>();
            var query = from t in dt.Tickets
                        select t;
            foreach(var ticket in query)
            {
                Tickets tic = new Tickets();
                tic.ID = ticket.ID;
                tic.userID = ticket.UserID;
                tic.scheduleID = ticket.ScheduleID;
                tic.cabinTypeID = ticket.CabinTypeID;
                tic.firstName = ticket.Firstname;
                tic.lastName = ticket.Lastname;
                tic.phone = ticket.Phone;
                tic.passportNumber = ticket.PassportNumber;
                tic.passportCountryID = ticket.PassportCountryID;
                tic.bookingReference = ticket.BookingReference;
                tic.confirmed = ticket.Confirmed;
                list.Add(tic);
            }
            return list;
        }
        
    }
}
