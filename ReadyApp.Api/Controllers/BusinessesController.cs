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

 
        // All users can only view business data through username search
        [HttpGet()]
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
        public ActionResult<BusinessDto> RegisterBusiness(BusinessRegisterDto businessRegister)
        {
            // *** START LOGIC ***
            // Mapping new business register data into business object
            var business = _mapper.Map<Business>(businessRegister);
            // checking if business is in fact a object with content (because of BusinessRegister reqiured attributes, There should always be content in User object)
            if (business == null) return NoContent();
            // cheacking if there already a business in data store with username. There must not be a business with same username
            if (_businessRepository.BusinessExistByUsername(business.Username)) return BadRequest();
            // assuming all steps was passed then register business into data store
            _businessRepository.RegisterBusiness(business);
            // save updated data in data store
            _businessRepository.Save();
            // *** END LOGIC ***

            // mapping pre-exist data into business dto (could of returned the business. may return business object rether then dto in future implementation)
            var businessToReturn = _mapper.Map<BusinessDto>(business);
            return CreatedAtRoute(
                "GetBusiness",
                new { businessId = businessToReturn.BusinessId },
                businessToReturn);

        }
    }
}
