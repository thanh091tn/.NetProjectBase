using Entities;
using UnitOfWork;

namespace Repository
{
    public interface IMainRepository<TEntity> : IBaseRepository<TEntity>
         where TEntity : BaseEntity
    {
        public IUnitOfWork<TodoContext> UnitOfWork { get; }
    }
}
