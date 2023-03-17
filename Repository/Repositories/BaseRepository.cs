using Microsoft.EntityFrameworkCore;
using Repository.Context;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
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

        public void Detached(TEntity obj)
        {
            _ctx.Entry(obj).State = EntityState.Detached;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _ctx.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public async ValueTask<TEntity?> Find(params object[] key)
        {
            return await _ctx.Set<TEntity>().FindAsync(key);
        }

        public async Task Update(TEntity obj)
        {
            _ctx.Entry(obj).State = EntityState.Modified;
            await _ctx.SaveChangesAsync();
        }

        public async Task Save(TEntity obj)
        {
            _ctx.Set<TEntity>().Add(obj);
            await _ctx.SaveChangesAsync();
        }

        public void SaveAll()
        {
            _ctx.SaveChanges();
        }

        public void Add(TEntity obj)
        {
            _ctx.Set<TEntity>().Add(obj);
        }

        public async Task Delete(Func<TEntity, bool> predicate)
        {
            _ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => _ctx.Set<TEntity>().Remove(del));

            await _ctx.SaveChangesAsync();
        }
    }
}
