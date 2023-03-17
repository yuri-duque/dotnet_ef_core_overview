using Domain.Models.Interfaces;

namespace Controller.Dtos.User
{
    public record UserSaveDTO : IUser
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
