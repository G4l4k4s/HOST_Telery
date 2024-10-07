using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HOST_Telery.Models
{
    [Table("guests")]
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("guest_firstname")]            
        public string FirstName { get; set; }

        [Column("guest_lastname")]
        public string LastName { get; set; }

        [Column("guest_email")]            
        public string Email { get; set; }

        [Column("guest_identificationNumber")]            
        public string IdentificationNumber { get; set; }

        [Column("guest_phoneNumber")]            
        public string PhoneNumber { get; set; }

        [Column("guest_arrivalDate")]
        public DateTime BristDate { get; set; }

    }
}