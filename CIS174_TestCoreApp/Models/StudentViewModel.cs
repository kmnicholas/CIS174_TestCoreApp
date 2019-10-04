/* This is the StudentViewModel. It contains the AccessLevel, 
 * as well as a list of students which are initialized here. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class StudentViewModel
    {
        public int AccessLevel { get; set; }

        public List<StudentModel> Students = new List<StudentModel> {
            new StudentModel {
                FirstName = "James",
                LastName = "Bond",
                Grade = 'B'
            },
            new StudentModel {
                FirstName = "Austin",
                LastName = "Powers",
                Grade = 'D'
            },
            new StudentModel {
                FirstName = "Tom",
                LastName = "Cruise",
                Grade = 'C'
            },
            new StudentModel {
                FirstName = "Tom",
                LastName = "Brady",
                Grade = 'B'
            }
        };

    }
}
