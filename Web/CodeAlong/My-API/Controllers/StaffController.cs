using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_API;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {

        List<Staff> staffList = new List<Staff>(){
            new Staff() { Id = 0, Name= "Daniel Johansson", Position= "King"},
            new Staff() { Id = 1, Name= "Din Mamma", Position= "VD"},
            new Staff() { Id = 2, Name= "Johan Danielsson", Position= "Receptionist"},
        };


        // GET: api/<StaffController>
        [HttpGet]
        public IEnumerable<Staff> Get()
        {
            return staffList;
        }

        // GET api/<StaffController>/5
        [HttpGet("{id}")]
        public Staff Get(int id)
        {
            return staffList[id];
        }

        // POST api/<StaffController>
        [HttpPost]
        public IActionResult Post([FromBody] Staff value)
        {
            staffList.Add(value);
            return Ok(value);
        }

        // PUT api/<StaffController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Staff value)
        {
            var s = staffList.FirstOrDefault(s => s.Id == id);
            if(s != null){
                s.Name = value.Name;
                s.Position = value.Position;
                return Ok(s);
            }
            return NotFound();
        }

        // DELETE api/<StaffController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var s = staffList?.FirstOrDefault(s => s.Id == id);
            if(s != null){
                staffList?.Remove(s);
                return Ok(s);
            }
            return NotFound();
        }
    }
}
