using Microsoft.EntityFrameworkCore;
using WebApplication2.Entities;

namespace WebApplication2.Repository
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