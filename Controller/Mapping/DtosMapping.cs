using AutoMapper;
using Controller.Dtos.User;
using Domain.Entities;

namespace Controller.Mapping
{
    public class DtosMapping : Profile
    {
        public DtosMapping()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserSaveDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();
        }
    }
}
