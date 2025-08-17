using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace TODOAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems => Set<TodoItem>();
    }
           

}
