using AutoMapper;
using ReadyApp.Api.Models;
using ReadyApp.Api.Models.Referance;
using ReadyApp.Domain;

namespace ReadyApp.Api.Profiles
{
    public class OwnerProfile : Profile
    {
        public OwnerProfile()
        {
            CreateMap<OwnerReferanceDto, Owner>();

            CreateMap<Owner, OwnerDto>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => src.OwnerId));
            

        }
    }
}
