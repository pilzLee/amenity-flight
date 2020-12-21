using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Airports
    {
        public int ID { get; set; }
        public int countryID { get; set; }
        public string IATACode { get; set; }
        public string name { get; set; }
        public Airports() { }
    }
}
