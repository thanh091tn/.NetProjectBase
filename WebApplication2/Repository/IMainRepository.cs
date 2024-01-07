using WebApplication2.Entities;
using WebApplication2.UnitOfWork;

namespace WebApplication2.Repository
{
    public interface IMainRepository<TEntity> : IBaseRepository<TEntity>
         where TEntity : BaseEntity
    {
        public IUnitOfWork<TodoContext> UnitOfWork { get; }
    }
}
