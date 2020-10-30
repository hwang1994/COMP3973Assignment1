using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Item
    {
        [Display (Name ="id")]
        [Key]
        public string id { get; set; }
        [Required]
        [Display(Name = "Volume Info")]
        public VolumeInfo volumeInfo { get; set; }
        //[Required]
        //[Display(Name = "Title")]
        //public string title { get; set; }
        //[Required]
        //[Display(Name = "Small Thumbnail URL")]
        //public string smallThumbnail { get; set; }
        //[Required]
        //[Display(Name = "Authors")]
        //public string[] authors { get; set; }
        //[Required]
        //[Display(Name = "Publisher")]
        //public string publisher { get; set; }
        //[Required]
        //[Display(Name = "Published Date")]
        //public string publishedDate { get; set; }
        //[Required]
        //[Display(Name = "Description")]
        //public string description { get; set; }
        //[Required]
        //[Display(Name = "ISBN_10")]
        //public int ISBN_10 { get; set; }
    }
}
