using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FielApi.Infrastructure.persistance.data
{
    public class TicketOrderMap : IEntityTypeConfiguration<TicketOrderModel>
    {
        public void Configure(EntityTypeBuilder<TicketOrderModel> builder)
        {
            builder.ToTable("TicketOrders");

            builder.HasKey(i => i.Id);
        }
    }
}
