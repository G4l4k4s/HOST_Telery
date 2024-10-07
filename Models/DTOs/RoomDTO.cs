using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HOST_Telery.Models.DTOs
{
    public class RoomDTO
    {
        [Required]
        [MaxLength(10)]
        public string RoomNumber { get; set; }

        [Required]
        public int RoomTypeId { get; set; }

        [Required]
        public double PricePerNight { get; set; }

        [Required]
        public bool Availavility { get; set; }

        [Required]
        public byte MaxOccupancyPerPerson { get; set; }
    }
}