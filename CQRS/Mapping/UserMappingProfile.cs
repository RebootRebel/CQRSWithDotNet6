using AutoMapper;
using CQRS.Models;
using PMCore.WebAPI.ViewModels;

namespace CQRS.Mapping
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserVm>().ReverseMap();
        }
    }
}
