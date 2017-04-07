using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResumePage.Models
{
    public class People
    {
        public int ID { get; set; }
        [Display(Name ="First Name")]
        public string FName  { get; set; }
        [Display(Name = "Last Name")]
        public string LName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Name")]
        public string FullName
        {
            get
            {
                return LName + ", " + FName;
            }
        }
        //public Job JobID { get; set; }
        //public Job Jobs { get; set; }
    }
}
