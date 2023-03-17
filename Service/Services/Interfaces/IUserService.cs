using Domain.Entities;

namespace Service.Services.Interfaces
{
    public interface IUserService
    {
        Task<IList<User>> GetAll();
        Task<User> FindById(string id);
        Task Save(User user);
        Task Update(User user);
        Task Delete(string id);
    }
}
