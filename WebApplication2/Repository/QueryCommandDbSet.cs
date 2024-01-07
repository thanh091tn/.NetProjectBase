using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication2.Repository
{
    public class QueryCommandDbSet<TEntity> : IQueryCommand<TEntity>
        where TEntity : class
    {
        public static QueryCommandDbSet<TEntity> Instance([NotNull] DbSet<TEntity> dbSet)
        {
            return new QueryCommandDbSet<TEntity>(dbSet);
        }

        private readonly DbSet<TEntity> _dbSet;

        private QueryCommandDbSet(DbSet<TEntity> dbSet)
        {
            _dbSet = dbSet;
        }

        public TEntity Add([NotNull] TEntity entity)
        {
            return _dbSet.Add(entity).Entity;
        }

        public async ValueTask<TEntity> AddAsync([NotNull] TEntity entity, CancellationToken cancellationToken = default)
        {
            var result = await _dbSet.AddAsync(entity, cancellationToken);
            return result.Entity;
        }

        public void AddRange([NotNull] IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public void AddRange([NotNull] params TEntity[] entities)
        {
            _dbSet.AddRange(entities);
        }

        public async Task AddRangeAsync([NotNull] IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddRangeAsync(entities, cancellationToken);
        }

        public async Task AddRangeAsync([NotNull] params TEntity[] entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public IAsyncEnumerable<TEntity> AsAsyncEnumerable()
        {
            return _dbSet.AsAsyncEnumerable();
        }

        public IQueryable<TEntity> AsQueryable()
        {
            return _dbSet.AsQueryable();
        }

        public TEntity Find(params object[] keyValues)
        {
            return _dbSet.Find(keyValues);
        }

        public IAsyncEnumerator<TEntity> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return _dbSet.AsAsyncEnumerable().GetAsyncEnumerator(cancellationToken);
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return _dbSet.AsEnumerable().GetEnumerator();
        }

        public void RemoveRange([NotNull] params TEntity[] entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void RemoveRange([NotNull] IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public TEntity Update([NotNull] TEntity entity)
        {
            return _dbSet.Update(entity).Entity;
        }

        public void UpdateRange([NotNull] params TEntity[] entities)
        {
            _dbSet.UpdateRange(entities);
        }

        public void UpdateRange([NotNull] IEnumerable<TEntity> entities)
        {
            _dbSet.UpdateRange(entities);
        }

    }
}
