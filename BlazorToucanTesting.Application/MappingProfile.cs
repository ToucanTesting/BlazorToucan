using AutoMapper;
using BlazorToucanTesting.Application.DTOs.Suites;
using BlazorToucanTesting.Application.DTOs;
using BlazorToucanTesting.Domain.Entities;

namespace BlazorToucanTesting.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<UserBase, UserDto>();
            //CreateMap<PasswordUserDto, UserBase>()
            //    .ForMember(dto => dto.Password, 
            //        m => m.MapFrom(u => BCrypt.Net.BCrypt.HashPassword(u.Password)));

            CreateMap<Suite, SuiteDto>();
            CreateMap<SuiteDto, Suite>();
        }
    }
}
