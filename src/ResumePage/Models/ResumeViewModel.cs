using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ResumePage.Models
{
    [NotMapped]
    public class ResumeViewModel
    {
        [Key]
        public int Id { get; set; }
        public People Contact { get; set; }
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerable<Education> Educations { get; set; }
    }
}
