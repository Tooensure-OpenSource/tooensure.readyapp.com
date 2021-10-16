using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadyApp.Api.Models;
using ReadyApp.data.ResourceParameters;
using ReadyApp.Data.Services;
using ReadyApp.Domain.Entity;

namespace ReadyApp.Api.Controllers
{
   
    [ApiController]
    [Route("api/users/{userId:guid}/businesses")]
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

        /// <summary>
        /// Every user has access to view every business
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        //public ActionResult<IEnumerable<BusinessDto>> GetBusinesses()
        //{
        //    var businessesFromRepo = _businessRepository.GetBusinesses();
        //    var result = _mapper.Map<IEnumerable<BusinessDto>>(businessesFromRepo);

        //    return Ok(result);
        //}

        
        // All users can only view business data through username search
        [HttpGet]
        [HttpHead]
        public ActionResult<IEnumerable<BusinessDto>> GetBusinesses(
            [FromQuery] BusinessResorcesParameters businessResorcesParameters)
        {
            var businessesFromRepo = _businessRepository.GetBusinesses(businessResorcesParameters);
            var result = _mapper.Map<IEnumerable<BusinessDto>>(businessesFromRepo);

            return Ok(result);
        }

        [HttpGet("{businessId}", Name = "GetBusiness")]
        public ActionResult<BusinessDto> GetBusiness(Guid businessId)
        {
            var businessFromRepo = _businessRepository.GetBusiness(businessId);
            var result = _mapper.Map<BusinessDto>(businessFromRepo);

            return Ok(result);
        }

        /// <summary>
        /// In order to register a business you'll need to set username and name of business as required
        /// </summary>
        /// <param name="business"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<BusinessDto> RegisterBusiness(BusinessRegisterDto business)
        {
            // Mapping new business register data into business object
            var businessEntity = _mapper.Map<Business>(business);
            // checking if business is in fact a object with content (because of BusinessRegister reqiured attributes, There should always be content in User object)
            if (businessEntity == null) return NoContent();

            if (_businessRepository.BusinessExist(businessEntity)) return BadRequest();
      
            _businessRepository.RegisterBusiness(businessEntity);

            _businessRepository.Save();

            var businessToReturn = _mapper.Map<BusinessDto>(businessEntity);
            return CreatedAtRoute(
                "GetBusiness",
                new { businessId = businessToReturn.BusinessId },
                businessToReturn);

        }
    }
}
