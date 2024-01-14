using ASP_28_12.Application.Catalog.User;
using ASP_28_12.Application.Catalog.User.Request;
using ASP_28_12.Application.Login;
using ASP_28_12.Application.Register;
using ASP_28_12.Domains.Entities;
using AutoMapper;

namespace ASP_28_12.Infrastructure.Extensions.AutoMapper.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserCreateRequest, User>();
            CreateMap<UserUpdateRequest, User>();
            CreateMap<UserPagingRequest, User>();
            CreateMap<RegisterRequest, User>();
            CreateMap<LoginRequest , User>();
            CreateMap<User, LoginRequest>();
        }
    }
}
