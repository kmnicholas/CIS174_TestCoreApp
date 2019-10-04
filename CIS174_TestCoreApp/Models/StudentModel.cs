/* This is the StudentModel used to create 
 * the list of students used in the StudentViewModel
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class StudentModel
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public char Grade { get; set; }
    }
}
