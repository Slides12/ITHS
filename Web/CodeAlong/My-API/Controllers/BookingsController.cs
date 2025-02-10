using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_API;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {

        //List<Booking> bookings = new List<Booking>(){
        //    new Booking (){ CheckInDate = new DateOnly(), CheckOutDate = new DateOnly(), CustomerId = 0, RoomId = 0 },
        //    new Booking (){ CheckInDate = new DateOnly(), CheckOutDate = new DateOnly(), CustomerId = 1, RoomId = 1 },
        //    new Booking (){ CheckInDate = new DateOnly(), CheckOutDate = new DateOnly(), CustomerId = 2, RoomId = 2 }
        //};
        // GET: api/<BookingsController>
        [HttpGet]
        public IEnumerable<Booking> Get()
        {
            using var db = new SQLITEContext();
            var bookings = db.Booking.ToList();

            return bookings;
        }

        // GET api/<BookingsController>/5
        [HttpGet("{id}")]
        public Booking Get(int id)
        {
            using var db = new SQLITEContext();
            var bookings = db.Booking.ToList();

            return bookings[id];
        }

        // POST api/<BookingsController>
        [HttpPost]
        public IActionResult Post([FromBody] Booking value)
        {
            using var db = new SQLITEContext();

            db.Booking.Add(value);
            db.SaveChanges();
            return Ok(value);
        }

        // PUT api/<BookingsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Booking value)
        {
            using var db = new SQLITEContext();
            var bookings = db.Booking.ToList();

            var booking = bookings.FirstOrDefault(b => b.CustomerId == id);
            if(booking != null){
                booking.CheckInDate = value.CheckInDate;
                booking.CheckOutDate = value.CheckOutDate;
                booking.RoomId = value.RoomId;
                db.SaveChanges();
                return Ok(booking);
            }
            return NotFound();
        }

        // DELETE api/<BookingsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using var db = new SQLITEContext();
            var bookings = db.Booking.ToList();

            var booking = bookings.FirstOrDefault(b => b.CustomerId == id);

            if(booking != null){
                bookings.Remove(booking);
                db.SaveChanges();
                return Ok(booking);
            }
            return NotFound();
        }
    }
}
