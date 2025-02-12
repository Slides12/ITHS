using Microsoft.AspNetCore.Mvc;
using API.Models;
using MongoDB.Bson;
using API.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{

    private readonly MongoDBRepository _mongoDBRepository;

    public TestController(MongoDBRepository mongoDBRepository)
    {
        _mongoDBRepository = mongoDBRepository;
    }

    // GET: api/<TestController>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> Get()
    {
        var products = await _mongoDBRepository.GetProductsFromMONGO();
        return Ok(products);
    }

    // GET api/<TestController>/5
    [HttpGet("getId/{id}")]
    public async Task<ActionResult<IEnumerable<Product>>> GetId(string id)
    {
        if (!ObjectId.TryParse(id, out ObjectId objectId))
        {
            return BadRequest("Not a valid ObjectId.");
        }

        var products = await _mongoDBRepository.GetAProductFromMONGObyID(objectId);
        return Ok(products);
    }

    // GET api/<TestController>/5
    [HttpGet("getName/{name}")]
    public async Task<ActionResult<IEnumerable<Product>>> GetName(string name)
    {
        var products = await _mongoDBRepository.GetAProductFromMONGObyName(name);
        return Ok(products);
    }

    // POST api/<TestController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Product value)
    {
        if (value.Name != "string")
        {
            await _mongoDBRepository.AddProductFromMONGO(value);
            return Ok(value);
        }
        return BadRequest(new {message = "Atleast give it a name."});
    }

    // PUT api/<TestController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(string id, [FromBody] Product value)
    {
        if (!ObjectId.TryParse(id, out ObjectId objectId))
        {
            return BadRequest("Not a valid ObjectId.");
        }

        await _mongoDBRepository.UpdateProductFromMONGO(value, objectId);
        return Ok(value);
    }

    // DELETE api/<TestController>/5
    [HttpDelete("deleteId/{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        if (!ObjectId.TryParse(id, out ObjectId objectId))
        {
            return BadRequest("Not a valid ObjectId.");
        }

        await _mongoDBRepository.DeleteProductFromMONGObyID(objectId);
        return Ok($"Deleted id: ${id}, successfully.");
    }

    // DELETE api/<TestController>/5
    [HttpDelete("deleteName/{name}")]
    public async Task<IActionResult> DeleteByName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return BadRequest("Put in something else then null or empty.");
        }

        await _mongoDBRepository.DeleteProductFromMONGObyName(name);
        return Ok($"Deleted Item: {name}, successfully.");
    }
}
