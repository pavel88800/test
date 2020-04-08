using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace APProject.Controllers
{
    public class MainAdminPageController : BaseApiController
    {
        [HttpGet]
        [Route("/categories")]
        public IActionResult GetCategories()
        {
            return Ok();
        }

        [HttpGet]
        [Route("/products")]
        public IActionResult GetProducts()
        {
            return Ok();
        }

        [HttpGet]
        [Route("/manufactures")]
        public IActionResult GetManufacturings()
        {
            return Ok();
        }
        /*херня жопа*/

    }
}
