using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class AccomplishmentModel
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfAccomplishment { get; set; }
       
    }
}
