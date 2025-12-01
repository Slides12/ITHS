using Microsoft.AspNetCore.Mvc;

namespace Hello1.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hello1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from api 1");
        }
    }
}
