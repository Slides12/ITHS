using Inlämningsuppgift_1.Interfaces;
using Inlämningsuppgift_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inlämningsuppgift_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //1
        private readonly IProductService _productService; /*= new ProductService();*/

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        //2
        //public class CreateProductRequest 
        //{ 
        //    public string Name { get; set; } = ""; 
        //    public decimal Price { get; set; } 
        //    public int Stock { get; set; } 
        //}

        [HttpGet]
        public IActionResult GetAll() => Ok(_productService.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var p = _productService.GetById(id);
            if (p == null) return NotFound();
            return Ok(p);
        }

        //3
        [HttpGet("search")]
        public IActionResult Search([FromQuery] string q, [FromQuery] decimal? maxPrice)
        {            
            var results = _productService.Search(q, maxPrice);
            //if (maxPrice.HasValue) results = results.Where(x => x.Price <= maxPrice.Value).ToList();
            return Ok(results);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateProductRequest req)
        {
            if (string.IsNullOrWhiteSpace(req.Name)) return BadRequest("Name required.");
            var created = _productService.Create(req.Name, req.Price, req.Stock);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPost("{id}/stock/increase")]
        public IActionResult IncreaseStock(int id, [FromQuery] int amount)
        {           
            if (amount <= 0) return BadRequest("Amount must be > 0");
            var ok = _productService.ChangeStock(id, amount);
            if (!ok) return NotFound();
            return Ok();
        }
    }
}
