using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Users
    {
        public int ID { get; set; }
        public int roleID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int officeID { get; set; }
        public DateTime birthDate { get; set; }
        public bool active { get; set; }
        public Users() { }
    }
}
