using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Offices
    {
        public int ID { get; set; }
        public int countryID { get; set; }
        public string title { get; set; }
        public string phone { get; set; }
        public string contact { get; set; }
        public Offices() { }
    }
}
