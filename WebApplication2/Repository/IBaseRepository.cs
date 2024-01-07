using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Using for inner query
        /// </summary>
        DbSet<TEntity> Entity { get; }

        /// <summary>
        /// Use only for select data
        /// </summary>
        /// <param name="ignoreGlobalFilter"></param>
        /// <returns></returns>
        IQueryable<TEntity> Query(bool ignoreGlobalFilter = false);
        IQueryCommand<TEntity> Command();
    }
}