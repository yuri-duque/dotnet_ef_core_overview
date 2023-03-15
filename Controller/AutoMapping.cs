using AutoMapper;
using Controller.Dtos.User;
using Domain.Entities;
using Repository.Entities;

namespace Controller
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            #region Repository

            CreateMap<User, UserEntity>().ReverseMap();

            #endregion

            #region Controller

            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<User, UserSaveDTO>().ReverseMap();
            CreateMap<User, UserUpdateDTO>().ReverseMap();

            #endregion
        }
    }
}
