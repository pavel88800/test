using Microsoft.AspNetCore.Mvc;

namespace APProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Test : ControllerBase
    {
        [HttpGet]
        public IActionResult Info()
        {
            return Ok("return");
        }
    }
}