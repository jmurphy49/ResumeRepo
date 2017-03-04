using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePage.Models
{
    public class Reference : People
    {
        [Required]
        public string Relation { get; set; }
        [Required]
        [Display(Name ="Known For")]
        public string knownFor { get; set; }
    }
}
