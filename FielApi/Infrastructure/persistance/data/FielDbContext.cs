using Microsoft.EntityFrameworkCore;

namespace FielApi.Infrastructure.persistance.data
{
    public class FielDbContext : DbContext
    {
        public FielDbContext(DbContextOptions<FielDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
