using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int? PeopleId { get; set; }
        [ForeignKey("PeopleId")]
        public virtual People Person { get; set; }
    }
}
