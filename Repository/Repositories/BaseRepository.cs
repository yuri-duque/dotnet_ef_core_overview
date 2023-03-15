using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace Repository.Repositories
{
    public abstract class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
    {
        private readonly BaseContext _ctx;

        public BaseRepository(BaseContext ctx)
        {
            _ctx = ctx;
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _ctx.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return _ctx.Set<TEntity>().Find(key);
        }

        public void Detached(TEntity obj)
        {
            _ctx.Entry(obj).State = EntityState.Detached;
        }

        public void Update(TEntity obj)
        {
            _ctx.Entry(obj).State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public virtual void Save(TEntity obj)
        {
            _ctx.Set<TEntity>().Add(obj);
            _ctx.SaveChanges();
        }

        public void SaveAll()
        {
            _ctx.SaveChanges();
        }

        public void Add(TEntity obj)
        {
            _ctx.Set<TEntity>().Add(obj);
        }

        public void Delete(Func<TEntity, bool> predicate)
        {
            _ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => _ctx.Set<TEntity>().Remove(del));

            _ctx.SaveChanges();
        }
    }
}
