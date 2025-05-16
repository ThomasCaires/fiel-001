using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace FielApi.Infrastructure.persistance.data
{
    public class GameMap : IEntityTypeConfiguration<GameModel>
    {
        public void Configure(EntityTypeBuilder<GameModel> builder)
        {
            builder.ToTable("Game");

            builder.HasKey(x => x.Id);
            builder.HasMany<TicketOrderModel>().WithOne(m => m.Game)
                .HasForeignKey(m => m.GameId)
                .HasConstraintName("FK_TikcketOrders_Matches_MatchId");
        }
    }
}
