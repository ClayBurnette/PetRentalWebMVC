using System;
using System.ComponentModel.DataAnnotations;

namespace PetRental.Models
{
    public class CustomerDetail
    {
        [Display(Name = "Customer ID")]
        public int CustomerId { get; set; }

        [Display(Name = "Customer Name")]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(30, ErrorMessage = "There Is A Max of 30 Characters")]
        public string FullName { get; set; }

        [Display(Name = "Address")]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(100, ErrorMessage = "There Is A Max of 100 Characters")]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        [MinLength(7, ErrorMessage = "There Is A Min of 7 Characters.")]
        [MaxLength(13, ErrorMessage = "There Is A Max of 13 Characters")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}