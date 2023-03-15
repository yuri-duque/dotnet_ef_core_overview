namespace Repository.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Func<TEntity, bool> predicate);
        ValueTask<TEntity?> Find(params object[] key);
        Task Update(TEntity obj);
        Task Delete(Func<TEntity, bool> predicate);
        void Add(TEntity obj);
        void SaveAll();
    }
}
