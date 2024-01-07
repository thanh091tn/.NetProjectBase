using Microsoft.EntityFrameworkCore;

namespace UnitOfWork
{
    public interface IUnitOfWork<DBContext> where DBContext : DbContext
    {
        DBContext Context { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        int SaveChanges();
    }
}
