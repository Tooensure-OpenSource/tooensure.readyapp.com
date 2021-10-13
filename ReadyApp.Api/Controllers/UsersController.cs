using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadyApp.Api.Models;
using ReadyApp.Api.Repositories;
using ReadyApp.Data.Services;
using ReadyApp.Domain;

namespace ReadyApp.Api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository ?? 
                throw new ArgumentNullException(nameof(userRepository));

            _mapper = mapper ?? 
                throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// There will not be a time where i'll want to get all users from the database,
        /// throughout the application, so i'm using GetUsers() method for debug reasons,
        /// NOT PRODUCTION
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> GetUsers()
        {
            var usersFromRepo = _userRepository.GetUsers();
     
            return Ok(_mapper.Map<IEnumerable<UserDto>>(usersFromRepo));
        }

        [HttpGet("{userId:guid}")]
        public ActionResult<UserDto> GetUsers(Guid userId)
        {
            var usersFromRepo = _userRepository.GetUser(userId);

            if (usersFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UserDto>(usersFromRepo));
        }
    }
}
