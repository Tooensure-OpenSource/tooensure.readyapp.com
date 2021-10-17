using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadyApp.Api.Models;
using ReadyApp.Data.Services;
using ReadyApp.Domain;

namespace ReadyApp.Api.Controllers
{

    [ApiController]
    [Route("api/users/{userId}/businesses/{businessId}/owners")]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerRepository _ownerRepository;
        private readonly IMapper _mapper;

        public OwnerController(IOwnerRepository ownerRepository, IMapper mapper)
        {
            _ownerRepository = ownerRepository ??
                throw new ArgumentNullException(nameof(ownerRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public ActionResult<IEnumerable<OwnerDto>> GetOwners(Guid businessId)
        {
            // Checking if there's in fact a owner with business id (guid)
            //if (!_ownerRepository.o(businessId)) return NotFound();

            // Retrieving owners from repository
            var ownersFromRepo = _ownerRepository.GetOwnersForBusiness(businessId);
            // Mapping Type owner to type owner dto
            var ownersToDto = _mapper.Map<IEnumerable<OwnerDto>>(ownersFromRepo);
            // return 200 code success
            return Ok(ownersToDto);

        }

        [HttpGet("{ownerId:guid}", Name = "GetBusinessOwner")]
        public ActionResult<OwnerDto> GetOwner(Guid ownerId)
        {
            if (!_ownerRepository.OwnerExists(ownerId)) return NotFound();

            var ownersFromRepo = _ownerRepository.GetOwner(ownerId);
            var result = _mapper.Map<OwnerDto>(ownersFromRepo);
            return Ok(result);
        }

        /// <summary>
        /// Problem here is, user Id points at the user id within route
        /// What happens when a owner wants to add a new user
        /// maybe there should be a request route where the owner/owners must all request validate request of a new owner.
        /// then user must accept invite. [Fixed...Pending]
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<OwnerDto> CreateOwnerForBusiness(Guid businessId, OwnerRegisterDto ownerRegister)
        {
            //if (_ownerRepository.OwnerExistForBusiness(businessId, ownerRegister.UserId)) return BadRequest();
            //ownerRegister.BusinessId = businessId;
            // mapping register data to a owner object
            var owner = _mapper.Map<Owner>(ownerRegister);

            // check if owner is already an owner of business
            //if (_ownerRepository.OwnerExistForBusiness(owner)) return BadRequest();
            // assuming all worked well then add owner to data store
            //_ownerRepository.CreateOwner(businessId, owner);
            //_ownerRepository.Save();

            var ownerToReturn = _mapper.Map<OwnerDto>(owner);
            return CreatedAtRoute(
                "GetBusinessOwner",
                new { userId = ownerToReturn.UserId,businessId = businessId, ownerId = ownerToReturn.OwnerId },
                ownerToReturn);

        }
    }
}
