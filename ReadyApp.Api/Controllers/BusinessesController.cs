using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadyApp.Api.Models;
using ReadyApp.Data.Services;
using ReadyApp.Domain.Entity;

namespace ReadyApp.Api.Controllers
{
   
    [ApiController]
    [Route("api/users/{userId}/[controller]")]
    public class BusinessesController : ControllerBase
    {
        private readonly IBusinessRepository _businessRepository;
        private readonly IMapper _mapper;

        public BusinessesController(
            IBusinessRepository businessRepository, IMapper mapper)
        {
            _businessRepository = businessRepository ??
                throw new ArgumentNullException(nameof(businessRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<BusinessDto>> GetBusinesses()
        {
            var businessesFromRepo = _businessRepository.GetBusinesses();
            var result = _mapper.Map<IEnumerable<BusinessDto>>(businessesFromRepo);

            return Ok(result);
        }

        [HttpGet("{businessId}")]
        public ActionResult<BusinessDto> GetBusiness(Guid businessId)
        {
            var businessFromRepo = _businessRepository.GetBusiness(businessId);
            var result = _mapper.Map<BusinessDto>(businessFromRepo);

            return Ok(result);
        }

    }
}
