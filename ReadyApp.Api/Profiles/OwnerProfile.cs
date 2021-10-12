using AutoMapper;
using ReadyApp.Api.Models;
using ReadyApp.Domain;

namespace ReadyApp.Api.Profiles
{
    public class OwnerProfile : Profile
    {
        public OwnerProfile()
        {
            CreateMap<Owner, OwnerDto>()
                .ForMember(
                    dest => dest.OwnerId,
                    opt => opt.MapFrom(src => src.OwnerId))
                .ForMember(
                    dest => dest.UserId,
                    opt => opt.MapFrom(src => src.UserId))
                .ForMember(
                    dest => dest.BusinessId,
                    opt => opt.MapFrom(src => src.BusinessId));
        }
    }
}
