using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FielApi.Infrastructure.persistance.data
{
    public class BuyerMap : IEntityTypeConfiguration<BuyerModel>
    {
        public void Configure(EntityTypeBuilder<BuyerModel> builder)
        {
            builder.ToTable("Buyer");

            builder.HasKey(x => x.Id);
            builder.HasMany<TicketOrderModel>().WithOne(b => b.Buyer)
                .HasForeignKey(t => t.BuyerId)
                .HasConstraintName("FK_TicketOrders_Buyers_BuyerId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
