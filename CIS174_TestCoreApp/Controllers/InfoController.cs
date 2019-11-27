/* Kyle Nicholas kmnicholas@dmacc.edu
 * This is the controller for Assignment 7.1. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.Controllers
{
    public class InfoController : Controller
    {
        // The Index method opens the Info/Index view
        public IActionResult Index()
        {
            return View(new InfoViewModel());
        }

        [HttpPost]
        public IActionResult CreatePerson(InfoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            return RedirectToAction("Index", "Home");
        }

        
    }
}
