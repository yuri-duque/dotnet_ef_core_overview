using Domain.Models.Interfaces;

namespace Controller.Dtos.User
{
    public record UserUpdateDTO : IUser
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
