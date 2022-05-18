using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetRental.Data
{
    public class Content
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(30, ErrorMessage = "There Is A Max of 30 Characters")]
        [Display(Name = "Pet Name")]
        public Guid OwnerId { get; set; }
        public string Title { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "There Is A Min of 3 Characters.")]
        [MaxLength(100, ErrorMessage = "There Is A Max of 100 Characters")]
        [Display(Name = "Photo Details")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Photo")]
        public byte[] Image { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
