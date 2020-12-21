using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AmenityDAO
    {
        AmonicDataContext dt = new AmonicDataContext();
        public Amenity aAmenity(int ID)
        {
            Amenity a = new Amenity();
            var query = from am in dt.Amenities
                        where am.ID == ID
                        select am;
            foreach (var amenity in query)
            {
                a.ID = amenity.ID;
                a.Service = amenity.Service;
                a.Price = amenity.Price;
            }
            return a;
        }
        public Amenity getByService(string service)
        {
            Amenity a = new Amenity();
            var query = from am in dt.Amenities
                        where am.Service == service
                        select am;
            foreach (var amenity in query)
            {
                a.ID = amenity.ID;
                a.Service = amenity.Service;
                a.Price = amenity.Price;
            }
            return a;
        }
    }
}
