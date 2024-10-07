using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HOST_Telery.Models.DTOs
{
    public class RoomTypeDTO
    {  
        [Required]
        [MaxLength(50)]
        public string name {get; set;}
        [Required]
        [MaxLength(255)]
        public string description {get; set;}
    }
}