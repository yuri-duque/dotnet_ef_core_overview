using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Entities;
using Repository.Interfaces;

namespace Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        private BaseRepository<UserEntity> _repository;
        private IMapper _mapper;

        public UserRepository(BaseContext ctx, IMapper mapper)
        {
            _repository = new BaseRepository<UserEntity>(ctx);
            _mapper = mapper;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var baseUsers = await _repository.GetAll().ToListAsync();

            var users = _mapper.Map<IEnumerable<User>>(baseUsers);

            return users;
        }
    }
}
