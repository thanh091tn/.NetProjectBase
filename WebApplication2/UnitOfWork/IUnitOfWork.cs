using Microsoft.EntityFrameworkCore;

namespace WebApplication2.UnitOfWork
{
    public interface IUnitOfWork<DBContext> where DBContext : DbContext
    {
        DBContext Context { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        int SaveChanges();
    }
}
