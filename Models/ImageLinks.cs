using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class ImageLinks:VolumeInfo
    {
        [Required]
        [Display(Name = "Small Thumbnail URL")]
        public string smallThumbnail { get; set; }
        public string thumbnail { get; set; }
    }
}
