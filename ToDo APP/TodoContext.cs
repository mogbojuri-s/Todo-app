using Microsoft.EntityFrameworkCore;

namespace ToDo_APP
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TodoApp;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
