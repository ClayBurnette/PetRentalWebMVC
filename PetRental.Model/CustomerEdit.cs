using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetRental.Models
{
    public class CustomerEdit
    {
        [Key]
        [Display(Name = "Customer ID")]
        public int CustomerId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(30, ErrorMessage = "There Is A Max of 30 Characters")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(30, ErrorMessage = "There Is A Max of 30 Characters")]
        public string LastName { get; set; }

        [Display(Name = "Customer Name")]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        [Required]
        [Display(Name = "Address")]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(100, ErrorMessage = "There Is A Max of 100 Characters")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [MinLength(7, ErrorMessage = "There Is A Min of 7 Characters.")]
        [MaxLength(13, ErrorMessage = "There Is A Max of 13 Characters")]
        public string PhoneNumber { get; set; }
    }
}