using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IList<User>> GetAll()
        {
            var users = await _userRepository.GetAll();

            return users.ToList();
        }

        public async Task<User> FindById(string id)
        {
            var user = await _userRepository.FindById(id);

            return user;
        }

        public async Task Save(User user)
        {
            await _userRepository.Save(user);
        }

        public async Task Update(User user)
        {
            await _userRepository.Update(user);
        }

        public async Task Delete(string id)
        {
            await _userRepository.Delete(id);
        }
    }
}