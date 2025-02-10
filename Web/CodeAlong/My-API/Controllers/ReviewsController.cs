using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_API;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        List<Review> reviews = new List<Review>() {
            new Review () { Comment = "Huh?", CustomerId = 1, Id= 0, Rating = 9 },
            new Review () { Comment = "VaSaru??", CustomerId = 1, Id= 1, Rating = 10 },
            new Review () { Comment = "Nä!", CustomerId = 1, Id= 2, Rating = 6 },
        };
        // GET: api/<ReviewsController>
        [HttpGet]
        public IEnumerable<Review> Get()
        {
            return reviews;
        }

        // GET api/<ReviewsController>/5
        [HttpGet("{id}")]
        public Review Get(int id)
        {
            return reviews[id];
        }

        // POST api/<ReviewsController>
        [HttpPost]
        public IActionResult Post([FromBody] Review value)
        {
            reviews.Add(value);
            return Ok(value);
        }

       
    }
}
