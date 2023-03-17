using AutoMapper;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Entities;
using Repository.Repositories.Interfaces;

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

        public async Task<User> FindById(string id)
        {
            var baseUser = await _repository.Find(id);

            var user = _mapper.Map<User>(baseUser);

            return user;
        }

        public async Task Save(User user)
        {
            var newUser = _mapper.Map<UserEntity>(user);

            await _repository.Save(newUser);
        }

        public async Task Update(User user)
        {
            var updateUser = _mapper.Map<UserEntity>(user);

            await _repository.Update(updateUser);
        }

        public async Task Delete(string id)
        {
            await _repository.Delete(x => x.Id == id);
        }
    }
}
