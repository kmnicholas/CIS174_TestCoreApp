/* Kyle Nicholas kmnicholas@dmacc.edu
 * This is the controller for Assignment 6.1. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Controllers
{
    public class StudentController : Controller
    {
        // The Index method opens the Student/Index view
        public IActionResult Index()
        {
            return View();
        }

        /* The StudentView method accepts a route parameter
            for access level, parses it to int and passes it
            to the StudentViewModel used when opening the 
            Student/StudentView view. 
        */
        public IActionResult StudentView(String id)
        {
            var viewModel = new StudentViewModel
            {
                AccessLevel = Int32.Parse(id)
            };


            return View(viewModel);
        }
    }
}
