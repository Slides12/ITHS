using Microsoft.AspNetCore.Mvc;

namespace Hello2.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hello2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from api 2");
        }
    }
}
