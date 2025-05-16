
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FielApi.Infrastructure.persistance.data
{
    public class SectorMap : IEntityTypeConfiguration<SectorModel>
    {
        public void Configure(EntityTypeBuilder<SectorModel> builder)
        {
            builder.ToTable("Sectors");
            builder.HasKey(x => x.Id);

            builder.HasMany<PositionModel>().WithOne(s => s.Sector)
                .HasForeignKey(p => p.SectorId)
                .HasConstraintName("FK_Positions_Sectors_SectorId");
        }
    }
}
