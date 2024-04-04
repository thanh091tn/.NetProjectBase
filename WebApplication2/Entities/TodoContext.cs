using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProjectBB.Entities;

namespace Entities
{
    public class TodoContext : DbContext
    {
        public TodoContext() { }
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
        public DbSet<User> User { get; set; } = null!;
    }
}
