namespace Domain.Interfaces
{
    public interface IUser
    {
        public string Id { get; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
