using Entities;
using Microsoft.EntityFrameworkCore;
using UnitOfWork;

namespace Repository
{
    public class MainRepository<TEntity> : IMainRepository<TEntity>
        where TEntity : BaseEntity
    {
        public IUnitOfWork<TodoContext> UnitOfWork { get; }

        /// <summary>
        /// Using for inner query
        /// </summary>
        public DbSet<TEntity> Entity { get => _dbSet; }

        private readonly DbSet<TEntity> _dbSet;

        private readonly IQueryCommand<TEntity> _queryCommand;

        public MainRepository(IUnitOfWork<TodoContext> unitOfWork)
        {
            UnitOfWork = unitOfWork;
            _dbSet = UnitOfWork.Context.Set<TEntity>();
            _queryCommand = QueryCommandDbSet<TEntity>.Instance(_dbSet);
        }

        public IQueryable<TEntity> Query(bool ignoreGlobalFilter = false)
        {
            if (ignoreGlobalFilter)
            {
                return _dbSet
                    .IgnoreQueryFilters()
                    .AsNoTracking();
            }
            return _dbSet
                .AsNoTracking();
        }

        IQueryCommand<TEntity> IBaseRepository<TEntity>.Command()
        {
            return _queryCommand;
        }
    }
}
