using Domain.Interfaces;

namespace Domain.Entities
{
    public class User : IUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
