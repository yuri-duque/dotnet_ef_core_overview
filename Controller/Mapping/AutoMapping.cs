using AutoMapper;
using Repository.Mapping;

namespace Controller.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            new RepositoryMapping();
            new DtosMapping();
        }
    }
}
