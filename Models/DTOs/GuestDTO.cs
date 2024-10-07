using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HOST_Telery.Models.DTOs
{
    public class GuestDTO
    {
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string IdentificationNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        public DateTime BristDate { get; set; }
    }
}