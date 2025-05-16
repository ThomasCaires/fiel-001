using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FielApi.Infrastructure.persistance.data
{
    public class FielDbContext : DbContext
    {
        public FielDbContext(DbContextOptions<FielDbContext> options) : base(options) { }

        public DbSet<BuyerModel> Buyers { get; set; }
        public DbSet<PositionModel> Positions { get; set; }
        public DbSet<GameModel> Games { get; set; }
        public DbSet<SectorModel> Sectors { get; set; }
        public DbSet<TicketOrderModel> TicketOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BuyerMap());
            modelBuilder.ApplyConfiguration(new GameMap());
            modelBuilder.ApplyConfiguration(new PositionMap());
            modelBuilder.ApplyConfiguration(new SectorMap());
            modelBuilder.ApplyConfiguration(new TicketOrderMap());
        }
    }
}
