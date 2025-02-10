using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_API;

namespace MyApp.Namespace
{


    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        // GET: api/<CustomersController>
        //List<Customers> customerList = new List<Customers>() {
        //    new Customers() { Id = 0, Name = "Daniel Johansson", ContactInfo = new ContactInfo() { Email="blabla@gmail.com", TelefonNummer= "00172093702"}},
        //    new Customers() { Id = 1, Name = "Simon Simonsson", ContactInfo = new ContactInfo() { Email="blabla@gmail.com", TelefonNummer= "00112393702"}},
        //    new Customers() { Id = 2, Name = "Anna Andersson", ContactInfo = new ContactInfo() { Email="blabla@gmail.com", TelefonNummer= "00112393202"}},
        //};
        [HttpGet]
        public IEnumerable<Customers> Get()
        {
            using var db = new SQLITEContext();
            var customerList = db.Customers.ToList();

            return customerList;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public Customers Get(int id)
        {
            using var db = new SQLITEContext();
            var customerList = db.Customers.ToList();

            return customerList[id];
        }

        // POST api/<CustomersController>
        [HttpPost]
        public IActionResult Post([FromBody] Customers value)
        {
            using var db = new SQLITEContext();
            db.Customers.Add(value);
            db.SaveChanges();
            return Ok(value);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Customers value)
        {

            using var db = new SQLITEContext();
            var customerList = db.Customers.ToList();

            var c = customerList.FirstOrDefault(c => c.Id == id);
            if(c != null){
                c.Name = value.Name;
                c.ContactInfo = value.ContactInfo;
                db.SaveChanges();
                return Ok(c);
            }
            return NotFound();
        }
       
    }
}
