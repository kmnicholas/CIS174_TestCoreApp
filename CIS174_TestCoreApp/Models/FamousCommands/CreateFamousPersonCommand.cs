using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models.FamousCommands
{
    public class CreateFamousPersonCommand
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

        [Display(Name = "Date of Birth")]
        [Range(typeof(DateTime), "1/1/1900", "12/31/2018")]
        public DateTime Birthdate { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string City { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string State { get; set; }
        public List<Accomplishment> Accomplishments { get; set; }

    }
}
