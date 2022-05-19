using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetRental.WebMVC1.Models
{
    public class Content
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(30, ErrorMessage = "There Is A Max of 30 Characters")]
        [Display(Name ="Pet Name")]
        public string Title { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(100, ErrorMessage = "There Is A Max of 100 Characters")]
        [Display(Name = "Photo Details")]
        public string Description { get; set; }

        [AllowHtml]
        [Required]
        [Display(Name ="Photo")]
        public byte[] Image { get; set; }
    }
}