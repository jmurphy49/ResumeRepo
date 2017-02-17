using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePage.Models
{
    public class Job
    {
        public int ID { get; set; }
        [Display(Name ="Job Description")]
        [Required]
        public string JobDescription { get; set; }
        [Display(Name ="Date Joined")]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}"),ApplyFormatInEditMode]
        [Required]
        public DateTime DateJoined { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}"), ApplyFormatInEditMode]
        [Required]
        public DateTime DateLeft { get; set; }
        [Required]
        [Display(Name ="Company Name")]
        public string Title { get; set; }
        [Display(Name ="Starting pay")]
        [Required]
        public decimal StartingPay { get; set; }
        public decimal EndingPay { get; set; }
        


    }
}
