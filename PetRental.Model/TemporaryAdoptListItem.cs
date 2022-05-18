using PetRental.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRental.Models
{
    public class TemporaryAdoptListItem
    {
        public enum TransactionType
        {
            Rental = 1,
            Return = 2
        }
        [Key]
        [Display(Name = "Transaction Id")]
        public int TransactionId { get; set; }
        [Required]
        [ForeignKey("Customer")]
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        [ForeignKey("Pet")]
        [Display(Name = "Pet")]
        public int PetId { get; set; }
        public virtual Pet Pet { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Rental Period - 1 Day Min & 20 Day Max.")]
        [Display(Name = "Number of Days")]
        public int RentalDuration { get; set; }
        [Required]
        [Range(1, 2000000, ErrorMessage = "Please Enter A Minimum of $1.00.")]
        [Display(Name = "Rental Cost")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal RentalCost { get; set; }
        [Required]
        [Display(Name = "Currently Available?")]
        public bool PetAvailability { get; set; }
        [Required]
        [Display(Name = "Transaction Type")]
        public TransactionType TransType { get; set; }
        [Required]
        [Display(Name = "Time of Transaction")]
        public DateTime TimeOfRental { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}