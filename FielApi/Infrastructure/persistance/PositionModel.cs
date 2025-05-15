using FielApi.core.enums;

namespace FielApi.Infrastructure.persistance
{
    public class PositionModel
    {
        public int Id { get; set; }
        public int ChairNumber { get; set; }
        public int SectorId { get; set; }
        public SectorModel? Sector { get; set; }
    }
}
