using Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUser _svUser;
        public UsersController(IUser svUser)
        {
            _svUser = svUser;
        }
        // GET: api/<UsersController>
        [HttpGet("User")]
        public IEnumerable<User> Get()
        {
            return _svUser.ListUsers();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost("User")]
        public void Post([FromBody] User user)
        {
            _svUser.Add(user);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] User user)
        {
            _svUser.Update(user);
        }

        //// DELETE api/<UsersController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    _svUser.Delete(id);
        //}
    }
}
