using Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategory _svCategory;
        public CategoriesController(ICategory svCategory)
        {
            _svCategory = svCategory;
        }
       
        [HttpGet("Category")]
        public IEnumerable<Category> Get()
        {
            return _svCategory.ListCategories();
        }

       
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}


        [HttpPost("Category")]
        public void Post([FromBody] Category category)
        {
            _svCategory.Add(category);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category category)
        {
            _svCategory.Update(category);
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svCategory.Delete(id);
        }
    }
}
