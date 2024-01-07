using System.Diagnostics.CodeAnalysis;

namespace WebApplication2.Repository
{
    public interface IQueryCommand<TEntity> where TEntity : class
    {
        TEntity Add([NotNull] TEntity entity);
        ValueTask<TEntity> AddAsync([NotNull] TEntity entity, CancellationToken cancellationToken = default);
        void AddRange([NotNull] IEnumerable<TEntity> entities);
        void AddRange([NotNull] params TEntity[] entities);
        Task AddRangeAsync([NotNull] IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
        Task AddRangeAsync([NotNull] params TEntity[] entities);
        IAsyncEnumerable<TEntity> AsAsyncEnumerable();
        IQueryable<TEntity> AsQueryable();
        TEntity Find(params object[] keyValues);
        void RemoveRange([NotNull] params TEntity[] entities);
        void RemoveRange([NotNull] IEnumerable<TEntity> entities);
        TEntity Update([NotNull] TEntity entity);
        void UpdateRange([NotNull] params TEntity[] entities);
        void UpdateRange([NotNull] IEnumerable<TEntity> entities);
    }
}