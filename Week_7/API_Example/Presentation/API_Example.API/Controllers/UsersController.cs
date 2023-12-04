using API_Example.API.Models;
using API_Example.Domain.Entities;
using API_Example.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Example.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly APIExampleDbContext _context;

        public UsersController(APIExampleDbContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IActionResult GetAll()
        {
            return Ok(_context.Users.ToList());
        }



        [HttpPost("[action]")]

        public IActionResult CreateUser([FromBody] CreateUserRequest createUserRequest)
        {
            User user = new()
            {
                FirstName = createUserRequest.FirstName,
                LastName = createUserRequest.LastName,
            };

            _context.Users.Add(user);

            //_context.SaveChanges();

            return Ok();
        }

        [HttpGet("[action]")]
        public string GetSomething(string name)
        {
            return name.Substring(0, 2);
        }
    }
}