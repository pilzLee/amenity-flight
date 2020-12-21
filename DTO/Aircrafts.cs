using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Aircrafts
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string makeModel { get; set; }
        public int totalSeats { get; set; }
        public int economySeats { get; set; }
        public int bussinessSeats { get; set; }
        public Aircrafts() { }
    }
}
