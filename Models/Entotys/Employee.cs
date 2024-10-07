using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HOST_Telery.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("employee_firstName")]
        public string FirstName { get; set; }

        [Column("employee_lastName")]
        public string LastName { get; set; }

        [Column("employee_email")]
        public string Email { get; set; }

        [Column("employee_identificationNumber")]
        public string IdentificationNumber { get; set; }

        [Column("employee_password")]
        public string Password { get; set; }

        public Employee(string firstName, string lastName, string email, string identificationNumber, string password)
        {
            FirstName = firstName.ToLower().Trim();
            LastName = lastName.ToLower().Trim();
            Email = email.ToLower().Trim();
            IdentificationNumber = identificationNumber.ToLower().Trim();
            Password = password;
        }
    }
}