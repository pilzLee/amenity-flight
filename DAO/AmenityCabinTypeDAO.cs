using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AmenityCabinTypeDAO
    {
        AmonicDataContext dt = new AmonicDataContext();
        public List<AmenitiesCabinType> listAmenity(int ID)
        {
            List<AmenitiesCabinType> list = new List<AmenitiesCabinType>();
            var query = from a in dt.AmenitiesCabinTypes
                        where a.CabinTypeID == ID
                        select a;
            foreach (var amen in query)
            {
                AmenitiesCabinType n = new AmenitiesCabinType();
                n.CabinTypeID = amen.CabinTypeID;
                n.AmenityID = amen.AmenityID;
                list.Add(n);
            }
            return list;
        }
    }
}
