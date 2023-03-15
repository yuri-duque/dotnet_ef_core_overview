using Domain.Entities;

namespace Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> FindById(string id);
        Task Save(User user);
        Task Update(User user);
        Task Delete(string id);
    }
}
