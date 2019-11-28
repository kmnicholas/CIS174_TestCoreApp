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
        public IEnumerable<HouseViewModel> Houses = new List<HouseViewModel>
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
            // Parse id parameter to int
            if (Int32.TryParse(id, out int intId))
            {
                // Use Where statement to filter house objects by Houses.ID
                return Ok(Houses.Where(x => x.ID == intId));
            }

            // If the parse fails, return NotFound
            return NotFound();
        }

        // Same as ViewHouse method, but uses Post to accept XML
        [Route("api/house/{id}")]
        [HttpPost]
        public IActionResult ViewHouseXML(string id)
        {
            // Parse id parameter to int
            if (Int32.TryParse(id, out int intId))
            {
                // Use Where statement to filter house objects by Houses.ID
                return Ok(Houses.Where(x => x.ID == intId));
            }

            // If the parse fails, return NotFound
            return NotFound();
        }

        [Route("api/house/create")]
        [HttpPost]
        public IActionResult CreateHouse(HouseViewModel house)
        {
            HouseViewModel savedHouse = house;
            
            return Ok(savedHouse);
        }
    }
}
