using AutoMapper;
using ReadyApp.Api.Models;
using ReadyApp.Api.Models.Creation;
using ReadyApp.Domain.Entity;
using ReadyApp.Shared.UserDto;

namespace ReadyApp.Api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserCreationDto, User>()
                 .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => src.FirstName))
                  .ForMember(
                    dest => dest.LastName,
                    opt => opt.MapFrom(src => src.LastName))
                .ForMember(
                    dest => dest.Username,
                    opt => opt.MapFrom(src => src.Username))
                .ForMember(
                    dest => dest.Password,
                    opt => opt.MapFrom(src => src.Password))
                .ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => src.EmailAddress));


            CreateMap<User, UserDto>()
                .ForMember(
                    dest => dest.UserId,
                    opt => opt.MapFrom(src => src.UserId))
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => $"{src.LastName}, {src.FirstName}"))
                .ForMember(
                    dest => dest.EmailAddress,
                    opt => opt.MapFrom(src => src.Email))
                .ForMember(
                        dest => dest.Username,
                        opt => opt.MapFrom(src => src.Username));

            CreateMap<UserRegister, User>()
                .ForMember(
                    dest => dest.Username,
                    opt => opt.MapFrom(src => src.Username))
                .ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => src.EmailAddress))
                .ForMember(
                    dest => dest.Password,
                    opt => opt.MapFrom(src => src.Password)); ;

        }
    }
}
