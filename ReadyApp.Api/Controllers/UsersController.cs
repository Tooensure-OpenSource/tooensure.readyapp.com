using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadyApp.Api.Models;
using ReadyApp.Api.Models.Creation;
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

        /// <summary>
        /// In cases where you need to get a specfic user by i unqie identifier (guid)
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("{userId:guid}", Name = "GetUser")]
        public ActionResult<UserDto> GetUser(Guid userId)
        {
            if (!_userRepository.UserExist(userId)) return BadRequest();
            // calls the data store repository and retieves the user with identifer
            var expectedUser = _userRepository.GetUser(userId);
            // in cases where there is not a user with identifer then check if user is actually null
            if (expectedUser == null) return NotFound();

            // using mapper to exclude sensitive information as a data transfer object (could of insert mapper into the return 200 reponse but rather not for cleaner code)
            var user = _mapper.Map<UserDto>(expectedUser);
            // return a successful user 
            return Ok(user);
        }

        /// <summary>
        /// Here's how you create a new user. Auto mapper will map user register to User class object
        /// </summary>
        /// <param name="userRegister"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<UserDto> RegisterUser(UserCreationDto userRegister)
        {         
            // Mapping the new user register data into user object
            var user = _mapper.Map<User>(userRegister);

            // checking if user is in fact a object with content (because of UserRegister reqiured attributes, There should always be content in User object)
            if (user == null) return NoContent();
            // check if there's a user in data store with username same username (There shouldn't have mutiple users with exact username) if so bad request or maybe another request
            if (_userRepository.UserExistByUsername(user)) return BadRequest();

            // Assuming there wasn't any returns, then creating new user will be succussful
            _userRepository.CreateUser(user);

            // Save database modification
            _userRepository.Save();

            // FINAL: Return user successfully created
            var userToReturn = _mapper.Map<UserDto>(user);
            return CreatedAtRoute(
                "GetUser", 
                new { userId = userToReturn.UserId },
                userToReturn);
        }
    }
}
