using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HOST_Telery.Models
{
    [Table("room_types")]
    public class RoomType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("room_type_name")]
        public string Name { get; set; }

        [Column("room_description")]
        public string Description { get; set; }

        public RoomType(string name, string description)
        {
            Name = name.Trim().ToLower();
            Description = description.Trim().ToLower();
        }
    }
}