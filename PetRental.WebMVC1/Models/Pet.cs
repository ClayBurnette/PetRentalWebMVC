using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetRental.WebMVC1.Models
{
    public class Pet
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
        [Key]
        [Display(Name = "Pet ID")]
        public int PetId { get; set; }
        [Required]
        [Display(Name = "Pet Name")]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(30, ErrorMessage = "There Is A Max of 30 Characters")]
        public string PetName { get; set; }
        [Required]
        [Display(Name = "Animal Type")]
        public AnimalType Type { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(50, ErrorMessage = "There Is A Max of 50 Characters")]
        [Display(Name = "Animal Breed")]
        public string AnimalBreed { get; set; }
        [Required]
        [Display(Name = "Animal Gender")]
        public AnimalGender Gender { get; set; }
        [Required]
        [Display(Name = "Vaccinated?")]
        public VaccinationRecords Vaccination { get; set; }
        [Required]
        [Display(Name = "Currently Available?")]
        public bool PetCount { get; set; }
        [Required]
        [Range(1, 2000000, ErrorMessage = "Please Enter A Minimum of $1.00.")]
        [Display(Name = "Daily Rental Cost")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal EstimatedCost { get; set; }
        [Display(Name = "Pet History")]
        public string PetHistory { get; set; }
        public virtual List<TemporaryAdopt> TemporaryAdopts { get; set; } = new List<TemporaryAdopt>();
    }
}