using Microsoft.EntityFrameworkCore;

namespace console_mysql.Models
{
    public class TodoContext: DbContext
    {
        public TodoContext()
        {

        }

        public TodoContext(DbContextOptions<TodoContext> options): base(options)
        {

        }

        public DbSet<TodoItem> TodoItem {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=classdb;User=root;Password=password;");
        }
    }
}
