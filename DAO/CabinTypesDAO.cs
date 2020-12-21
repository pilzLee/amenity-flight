using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CabinTypesDAO
    {
        AmonicDataContext dt = new AmonicDataContext();
        public CabinType aCabinType(int ID)
        {
            CabinType c = new CabinType();
            var query = from cab in dt.CabinTypes
                        where cab.ID == ID
                        select cab;
            foreach(var cabinType in query)
            {
                c.ID = cabinType.ID;
                c.Name = cabinType.Name;
            }
            return c;
        }
    }
}
