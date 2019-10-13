using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class InfoViewModel
    {
        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25)]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public int Age { get; set; }

        [Display(Name = "Date of Birth")]
        [Range(typeof(DateTime), "1/1/1900", "12/31/2018")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [Display(Name = "Confirm Name")]
        public string ConfirmPassword { get; set; }

        public string Country { get; set; }
    }
}
