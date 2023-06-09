using Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartsController : ControllerBase
    {
        private readonly IShoppingCart _svShoppingCart;
        public ShoppingCartsController(IShoppingCart svShoppingCart)
        {
            _svShoppingCart = svShoppingCart;
        }

        [HttpGet("ShoppingCart")]
        public IEnumerable<ShoppingCart> Get()
        {
            return _svShoppingCart.ListShoppingCarts();
        }


        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost("ShoppingCart")]
        public void Post([FromBody] ShoppingCart shoppingCart)
        {
            _svShoppingCart.Add(shoppingCart);
        }

   
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ShoppingCart shoppingCart)
        {
            _svShoppingCart.Update(id, shoppingCart);
        }

  
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svShoppingCart.Delete(id);
        }
    }
}
