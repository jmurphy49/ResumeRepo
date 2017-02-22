using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePage.Models
{
    public class Education
    {
        public int ID { get; set; }
        public string Level { get; set; }
        public string Establishment { get; set; }
        public DateTime Graduated { get; set; }

    }
}
