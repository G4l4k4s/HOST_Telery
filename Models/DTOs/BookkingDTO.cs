using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HOST_Telery.Models.DTOs
{
    public class BookkingDTO
    {
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public double TotalCost { get; set; }

        [Required]
        public int RoomId { get; set; }

        [Required]
        public int GuestId { get; set; }

        [Required]
        public int EmployeeId { get; set; }
    }

    internal class ErrorMessageAttribute : Attribute
    {
    }
}