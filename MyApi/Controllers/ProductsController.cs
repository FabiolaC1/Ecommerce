using Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
         private readonly IProduct _svProduct;
        public ProductsController(IProduct svProduct)
        {
            _svProduct = svProduct;
        }
        
        [HttpGet("Product")]
        public IEnumerable<Product> Get()
        {
            return _svProduct.GetAll();
        }

        
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _svProduct.GetById(id);
        }

       
        [HttpPost("Product")]
        public void Post([FromBody] Product product)
        {
            _svProduct.Add(product);
        }

        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            _svProduct.Update(id, product);
        }

        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svProduct.Delete(id);
        }
    }
}