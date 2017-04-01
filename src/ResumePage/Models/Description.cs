using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumePage.Models
{
    public class Description : JobDescriptions
    {
        public int ID { get; set; }
        [DataType(DataType.MultilineText), StringLength(2000)]
        public string Summary { get; set; }
       
    }
}
