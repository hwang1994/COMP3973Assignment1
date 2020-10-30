using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class VolumeInfo:Item
    {
        [Required]
        [Display(Name = "Title")]
        public string title { get; set; }
        [Required]
        [Display(Name = "Authors")]
        public string[] authors { get; set; }
        [Required]
        [Display(Name = "Publisher")]
        public string publisher { get; set; }
        [Required]
        [Display(Name = "Published Date")]
        public string publishedDate { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string description { get; set; }
        [Required]
        public ImageLinks imageLinks { get; set; }
        [Required]
        [Display(Name = "ISBN_10")]
        public IndustryIdentifier[] industryIdentifiers { get; set; }
    }
}
