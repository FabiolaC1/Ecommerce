using Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {

        private readonly IOrderItem _svOrderItem;
        public OrderItemsController(IOrderItem svOrderItem)
        {
            _svOrderItem = svOrderItem;
        }
        [HttpGet("OrderItem")]
        public IEnumerable<OrderItem> Get()
        {
            return _svOrderItem.ListOrderItems();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("OrderItem")]
        public void Post([FromBody] OrderItem orderItem)
        {
            _svOrderItem.Add(orderItem);
        }

        [HttpPut("{id}")]
        public void Put([FromBody] OrderItem orderItem)
        {
            _svOrderItem.Update(orderItem); 
        }

        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    _svOrderItem.Delete(id);
        //}
    }
}
