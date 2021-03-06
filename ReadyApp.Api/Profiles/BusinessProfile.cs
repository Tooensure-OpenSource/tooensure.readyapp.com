using AutoMapper;
using ReadyApp.Api.Models;
using ReadyApp.Api.Models.Creation;
using ReadyApp.Domain.Entity;

namespace ReadyApp.Api.Profiles
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            CreateMap<BusinessCreationDto, Business>();


            CreateMap<Business, BusinessDto>()
                .ForMember(
                    dest => dest.BusinessId,
                    opt => opt.MapFrom(src => src.BusinessId))
                .ForMember(
                    dest => dest.BusinessName,
                    opt => opt.MapFrom(src => src.Name));


        }
    }
}
