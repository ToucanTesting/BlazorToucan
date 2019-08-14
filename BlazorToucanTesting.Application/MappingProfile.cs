using AutoMapper;
using BlazorToucanTesting.Application.DTOs.Suites;
using BlazorToucanTesting.Application.DTOs.Users;
using BlazorToucanTesting.Domain.Entities;

namespace BlazorToucanTesting.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<PasswordUserDto, User>()
                .ForMember(dto => dto.Password, 
                    m => m.MapFrom(u => BCrypt.Net.BCrypt.HashPassword(u.Password)));

            CreateMap<Suite, SuiteDto>();
            CreateMap<SuiteDto, Suite>();
        }
    }
}
