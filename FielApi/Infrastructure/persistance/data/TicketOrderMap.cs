using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FielApi.Infrastructure.persistance.data
{
    public class TicketOrderMap
    {
        public void Configure(EntityTypeBuilder<TicketOrderModel> builder)
        {
            builder.ToTable("TicketOrder");

            builder.HasKey(i => i.Id);
        }
    }
}
