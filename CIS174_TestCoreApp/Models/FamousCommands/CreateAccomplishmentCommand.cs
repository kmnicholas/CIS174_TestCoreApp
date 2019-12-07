using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models.FamousCommands
{
    public class CreateAccomplishmentCommand
    {
        [Required]
        [Display(Name = "Name of accomplishment")]
        public string Name { get; set; }
        [Required]
        public DateTime DateOfAccomplishment { get; set; }
    }
}
