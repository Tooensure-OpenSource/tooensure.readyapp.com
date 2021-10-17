using AutoMapper;
using ReadyApp.Api.Models;
using ReadyApp.Domain;

namespace ReadyApp.Api.Profiles
{
    public class OwnerProfile : Profile
    {
        public OwnerProfile()
        {
            CreateMap<OwnerRegisterDto, Owner>();

            CreateMap<Owner, OwnerDto>();
            

        }
    }
}
