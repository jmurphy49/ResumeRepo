using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePage.Models
{
    public class People
    {
        public int ID { get; set; }
        public string FName  { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Job JobID { get; set; }
        public Job Jobs { get; set; }
    }
}
