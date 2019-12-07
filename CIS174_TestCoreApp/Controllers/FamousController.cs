using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using CIS174_TestCoreApp.Models.FamousCommands;
using CIS174_TestCoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class FamousController : Controller
    {
        public FamousService _service;

        public FamousController(FamousService service)
        {
            _service = service;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFamousPerson()
        {
            return View(new CreateFamousPersonCommand());
        }

        [HttpPost]
        public IActionResult CreateFamousPerson(CreateFamousPersonCommand cmd)
        {
            if (!ModelState.IsValid)
            {
                return View(cmd);
            }

            _service.CreateFamousPerson(cmd);
            return RedirectToAction("Index", "Home");
        }
    }
}
