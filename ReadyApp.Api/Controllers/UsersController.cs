using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadyApp.Api.Models;
using ReadyApp.Api.Repositories;
using ReadyApp.Data.Services;
using ReadyApp.Domain;
using ReadyApp.Domain.Entity;
using ReadyApp.Shared.UserDto;
using System;
using System.Collections.Generic;

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

        [HttpGet("{userId:guid}", Name = "GetUser")]
        public ActionResult<UserDto> GetUsers(Guid userId)
        {
            var usersFromRepo = _userRepository.GetUser(userId);

            if (usersFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UserDto>(usersFromRepo));
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> RegisterUser(UserRegister userRegister)
        {
            var registerEntity = _mapper.Map<User>(userRegister);

            if (registerEntity == null) return NoContent();
            if (_userRepository.UserExists(registerEntity)) return BadRequest();

            _userRepository.CreateUser(registerEntity);
            _userRepository.Save();

            var userToReturn = _mapper.Map<UserDto>(registerEntity);
            return CreatedAtRoute(
                "GetUser", 
                new { userId = userToReturn.UserId },
                userToReturn);
        }
    }
}
