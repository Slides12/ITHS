using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TopShop.Core.Interfaces;
using TopShop.Infrastructure.Interfaces;

namespace TopShop.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService productservice)
        {
            _service = productservice;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _service.GetProducts();
            return Ok(products);
        }
    }
}
