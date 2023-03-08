using Microsoft.EntityFrameworkCore;

namespace Controller.Repository
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }
    }

    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
