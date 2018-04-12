using System;
using System.ComponentModel.DataAnnotations;

namespace EzestCodingTest.DAL.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Username")]
        [MaxLength(150)]
        public string Username { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
