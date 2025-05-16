
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FielApi.Infrastructure.persistance.data
{
    public class PositionMap : IEntityTypeConfiguration<PositionModel>
    {
        public void Configure(EntityTypeBuilder<PositionModel> builder)
        {
            builder.ToTable("Positions");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.ChairNumber).IsUnique();

            builder.HasMany<TicketOrderModel>().WithOne(p => p.Position)
                .HasForeignKey(p => p.PositionId)
                .HasConstraintName("FK_TicketOrders_Positions_PositionId");
        }
    }
}
