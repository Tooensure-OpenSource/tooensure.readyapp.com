using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadyApp.Api.Models;
using ReadyApp.Data.Services;

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
        /// <summary>
        /// Seems more right to interate through db sets like this and 
        /// more logic when using ids
        /// </summary>
        /// <returns></returns>
        //[HttpGet("api/users/businesses/owners")]
        //public ActionResult<IEnumerable<OwnerDto>> GetOwners()
        //{
        //    var ownersFromRepo = _ownerRepository.GetOwners();
        //    var result = _mapper.Map<IEnumerable<OwnerDto>>(ownersFromRepo);
        //    return Ok(result);
        //}

        [HttpGet]
        public ActionResult<IEnumerable<OwnerDto>> GetOwners(Guid businessId)
        {
            // Checking if there's in fact a business (businessId:guid) within owner tables
            if (!_ownerRepository.OwnerExists(businessId)) return NotFound();

            // Retrieving owners from repository
            var ownersFromRepo = _ownerRepository.GetOwnersForBusiness(businessId);
            // Mapping Type owner to type owner dto
            var ownersToDto = _mapper.Map<IEnumerable<OwnerDto>>(ownersFromRepo);
            // return 200 code success
            return Ok(ownersToDto);

        }

        [HttpGet("{ownerId:guid}")]
        public ActionResult<OwnerDto> GetOwner(Guid ownerId)
        {
            if (!_ownerRepository.OwnerExists(ownerId))
            {
                return NotFound();
            }
            var ownersFromRepo = _ownerRepository.GetOwner(ownerId);
            var result = _mapper.Map<OwnerDto>(ownersFromRepo);
            return Ok(result);
        }

        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        //[HttpPost]
        //public ActionResult<OwnerDto> RegisterOwner()
        //{

        
        //}
    }
}
