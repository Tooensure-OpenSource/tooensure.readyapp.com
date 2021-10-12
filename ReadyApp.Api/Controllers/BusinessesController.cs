using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadyApp.Data.Services;

namespace ReadyApp.Api.Controllers
{
   
    [ApiController]
    [Route("api/users/{userId}/[controller]")]
    public class BusinessesController : ControllerBase
    {
        private readonly IBusinessRepository _businessRepository;
        private readonly IMapper _mapper;

        public BusinessesController(IBusinessRepository businessRepository, IMapper mapper)
        {
            _businessRepository = businessRepository ??
                throw new ArgumentNullException(nameof(businessRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

    }
}
