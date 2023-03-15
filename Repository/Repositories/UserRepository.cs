using Repository.Context;
using Repository.Entities;

namespace Repository.Repositories
{
    public class UserRepository : BaseRepository<UserEntity>
    {
        public UserRepository(BaseContext ctx) : base(ctx) { }
    }
}
