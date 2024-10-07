using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HOST_Telery.Models
{
    [Table("rooms")]
    public class Room
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("room_number")]
        public string RoomNumber { get; set; }

        [Column("room_type_id")]
        public int RoomTypeId { get; set; }

        [Column("price_per_night")]
        public double PricePerNight { get; set; }

        [Column("room_availability")]
        public bool Availavility { get; set; }

        [Column("max_occupancy_per_sperson")]
        public byte MaxOccupancyPerPerson { get; set; }

        [JsonIgnore]
        [ForeignKey("RoomTypeId")]
        public RoomType RoomType { get; set; }


        public Room (String roomNumber, int roomTypeId, double pricePerNight, bool availavility, byte maxOccupancyPerPerson)
        {
            RoomNumber = roomNumber.ToLower().Trim();
            RoomTypeId = roomTypeId;
            PricePerNight = pricePerNight;
            Availavility = availavility;
            MaxOccupancyPerPerson = maxOccupancyPerPerson;
        }
    }
}