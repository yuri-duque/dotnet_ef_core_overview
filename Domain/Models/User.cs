using Domain.Interfaces;

namespace Domain.Entities
{
    public class User : IBaseEntity, IUser
    {
        public string Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
