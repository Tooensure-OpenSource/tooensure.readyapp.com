using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadyApp.Api.Models;
using ReadyApp.Data.Services;

namespace ReadyApp.Api.Controllers
{

    [ApiController]
    [Route("api/users/{userId}/businesses/{businessId}/[controller]")]
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

        [HttpGet]
        public ActionResult<OwnerDto> GetOwners()
        {
            var ownersFromRepo = _ownerRepository.GetOwners();
            var result = _mapper.Map<OwnerDto>(ownersFromRepo);
            return Ok(result);
        }

        [HttpGet("{ownerId:guid}")]
        public ActionResult<OwnerDto> GetOwner(Guid ownerId)
        {
            var ownersFromRepo = _ownerRepository.GetOwner(ownerId);
            var result = _mapper.Map<OwnerDto>(ownersFromRepo);
            return Ok(result);
        }

        public ActionResult<IEnumerable<OwnerDto>> OwnersOfBusiness(Guid businessId)
        {
            var ownersOfBusinessFromRepo = _ownerRepository.GetOwnersForBusiness(businessId);
            var result = _mapper.Map<OwnerDto>(ownersOfBusinessFromRepo);
            return Ok(result);

        }

        public ActionResult<OwnerDto> GetOwnerOfUser(Guid userId)
        {
            var ownersFromRepo = _ownerRepository.GetOwnerOfUser(userId);
            var result = _mapper.Map<OwnerDto>(ownersFromRepo);
            return Ok(result);
        }
    }
}
