using Inlämningsuppgift_1.Interfaces;
using Inlämningsuppgift_1.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inlämningsuppgift_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        //1
        private readonly ICartService _cartService; /*= new CartService();*/
        private readonly IUserService _userService; /*= new UserService();*/

        public CartController(ICartService cartService, IUserService userService)
        {
            _cartService = cartService;
            _userService = userService;
        }
        //2
        //public class AddItemRequest { public int ProductId { get; set; } public int Quantity { get; set; } }

        //3
        [HttpPost("add-item")]
        public IActionResult AddItemToCart([FromHeader(Name = "X-Auth-Token")] string token, [FromBody] AddItemRequest req)
        {
            var user = _userService.GetUserByToken(token);
            if (user == null) return Unauthorized();

            //if (req.Quantity <= 0) return BadRequest("Quantity must be > 0");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _cartService.AddToCart(user.Id, req.ProductId, req.Quantity);
            return Ok();
        }

        //4
        [HttpGet("get-cart")]
        public IActionResult GetUserCart([FromHeader(Name = "X-Auth-Token")] string token)
        {
            var user = _userService.GetUserByToken(token);
            if (user == null) return Unauthorized();

            var cart = _cartService.GetCartForUser(user.Id);
            
            //var detailed = cart.Select(ci =>
            //{
            //    var p = _productService.GetById(ci.ProductId);
            //    return new { ci.ProductId, ProductName = p?.Name, ci.Quantity, UnitPrice = p?.Price };
            //});

            return Ok(cart);
        }

        //5
        [HttpPost("remove-item")]
        public IActionResult RemoveCartItem([FromHeader(Name = "X-Auth-Token")] string token, [FromQuery] int productId)
        {
            var user = _userService.GetUserByToken(token);
            if (user == null) return Unauthorized();

            _cartService.RemoveFromCart(user.Id, productId);
            return Ok();
        }

        //6
        [HttpPost("clear-cart")]
        public IActionResult ClearCart([FromHeader(Name = "X-Auth-Token")] string token)
        {
            var user = _userService.GetUserByToken(token);
            if (user == null) return Unauthorized();

            _cartService.ClearCart(user.Id);
            return Ok();
        }
    }
}
