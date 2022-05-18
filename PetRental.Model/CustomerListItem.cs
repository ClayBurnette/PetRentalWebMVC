using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRental.Models
{
    public class CustomerListItem
    {
        [Key][Display(Name = "Customer ID")] public int CustomerId { get; set; }

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

        public DateTimeOffset CreatedUtc { get; set; }
    }
}