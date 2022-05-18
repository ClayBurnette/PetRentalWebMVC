using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRental.Models
{
    public class PetListItem
    {
        public enum AnimalType
        {
            Dog = 1,
            Cat = 2,
            Rabbit = 3,
        }
        public enum AnimalGender
        {
            Male = 1,
            Female = 2
        }
        public enum VaccinationRecords
        {
            Yes = 1,
            No = 2
        }
        [Display(Name = "Pet ID")]
        public int PetId { get; set; }
        [Display(Name = "Pet Name")]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(30, ErrorMessage = "There Is A Max of 30 Characters")]
        public string PetName { get; set; }
        [Display(Name = "Animal Type")]
        public AnimalType Type { get; set; }
        [Display(Name = "Animal Breed")]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(50, ErrorMessage = "There Is A Max of 50 Characters")]
        public string AnimalBreed { get; set; }
        [Display(Name = "Animal Gender")]
        public AnimalGender Gender { get; set; }
        [Display(Name = "Vaccinated?")]
        public VaccinationRecords Vaccination { get; set; }
        [Display(Name = "Currently Available?")]
        public bool PetCount { get; set; }
        [Display(Name = "Daily Rental Cost")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal EstimatedCost { get; set; }
        [Display(Name = "Pet History")]
        public string PetHistory { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}