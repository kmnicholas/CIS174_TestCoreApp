using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.API
{
    public class HouseController : Controller
    {
        public IEnumerable<HouseViewModel> Houses = new HouseViewModel[]
        {
            new HouseViewModel
            {
                ID = 1,
                Bedrooms = 4,
                SquareFeet = 1854,
                DateBuilt = new DateTime(1974,5,25),
                Flooring = "Carpet"
            },
            new HouseViewModel
            {
                ID = 2,
                Bedrooms = 3,
                SquareFeet = 1675,
                DateBuilt = new DateTime(2015,10,17),
                Flooring = "Hardwood"
            }
        };

        public List<HouseViewModel> HousesList = new List<HouseViewModel>
        {
            new HouseViewModel
            {
                ID = 1,
                Bedrooms = 4,
                SquareFeet = 1854,
                DateBuilt = new DateTime(1974,5,25),
                Flooring = "Carpet"
            },
            new HouseViewModel
            {
                ID = 2,
                Bedrooms = 3,
                SquareFeet = 1675,
                DateBuilt = new DateTime(2015,10,17),
                Flooring = "Hardwood"
            }
        };

        [Route("api/house")]
        [HttpGet]
        public IActionResult ViewHouses()
        {
            return Ok(Houses);
        }

        [Route("api/house/{id}")]
        [HttpGet]
        public IActionResult ViewHouse(string id)
        {
            return Ok(HousesList[Int32.Parse(id) - 1]);
        }

        [Route("api/house/create")]
        [HttpPost]
        public IActionResult CreateHouse()
        {
            return null;
        }
    }
}
