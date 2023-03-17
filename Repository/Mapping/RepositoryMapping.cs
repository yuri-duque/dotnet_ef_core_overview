using AutoMapper;
using Domain.Entities;
using Repository.Entities;

namespace Repository.Mapping
{
    public class RepositoryMapping : Profile
    {
        public RepositoryMapping()
        {
            CreateMap<User, UserEntity>().ReverseMap();
        }
    }
}
