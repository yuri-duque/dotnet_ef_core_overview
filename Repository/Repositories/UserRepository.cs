using Repository.Context;
using Repository.Entities;
using Repository.Interfaces;

namespace Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private BaseRepository<UserEntity> _repository;

        public UserRepository(BaseContext ctx)
        {
            _repository = new BaseRepository<UserEntity>(ctx);
        }


    }
}
