using ChatApi.Models.Interfaces;
using ChatApi.Models.Services;
using Domain.Context;
using Domain.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;

namespace ChatApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        private readonly ChatContext _context;

        public UserController(ILogger<UserController> logger, ChatContext context)
        {
            _logger = logger;
            _context = context;
            _userService = new UserService(context);
        }

        [HttpPut("AddUser")]
        public ActionResult AddUser([FromQuery] string FirstName, [FromQuery] string LastName,
            [FromQuery] string Email)
        {
            var user = new User()
            {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email
            };

            _userService.AddUser(user);
            return Ok();
        }
    }
}