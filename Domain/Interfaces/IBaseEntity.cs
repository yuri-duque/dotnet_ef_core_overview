namespace Domain.Interfaces
{
    public interface IBaseEntity
    {
        public string Id { get; }
        public DateTime CreatedDate { get; }
        public DateTime? UpdatedDate { get; }
    }
}
