using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class IndustryIdentifier
    {
        public string type { get; set; }
        [Display(Name = "ISBN_10")]
        public string identifier { get; set; }
    }
}
