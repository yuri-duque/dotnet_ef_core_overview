using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Entities;

namespace Repository.Context
{
    public class BaseContext : DbContext
    {
        private readonly string _connectionString;

        public BaseContext(DbContextOptions<BaseContext> options, IConfiguration configuration) : base(options)
        {
            this._connectionString = configuration.GetConnectionString("Default") ?? "";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            UserEntity.Map(modelBuilder);
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
