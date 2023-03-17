using Domain.Models.Interfaces;

namespace Controller.Dtos.User
{
    public record UserDTO : IBaseEntity, IUser
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public string Email { get; set; }
        public string Name { get; set; }
    }
}
