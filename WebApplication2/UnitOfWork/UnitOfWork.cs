using Microsoft.EntityFrameworkCore;

namespace WebApplication2.UnitOfWork
{
    public class UnitOfWork<DBContext> : IUnitOfWork<DBContext>
        where DBContext : DbContext
    {
        public DBContext Context { get; }

        public UnitOfWork(DBContext dbContext)
        {
            Context = dbContext;
        }
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await Context.SaveChangesAsync(false, cancellationToken);
        }
        public int SaveChanges()
        {
            return Context.SaveChanges(false);
        }
    }
}
