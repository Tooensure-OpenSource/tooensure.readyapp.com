using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadyApp.Api.Repositories;
using ReadyApp.Data.Services;
using ReadyApp.Domain;

namespace ReadyApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult<User> GetUsers()
        {
            return Ok(_userRepository.GetUsers());
        }
    }
}
