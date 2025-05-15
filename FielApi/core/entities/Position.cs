using FielApi.core.enums;

namespace FielApi.core.entities
{
    public class Position
    {
        public int Id { get; set; }
        public int ChairNumber { get; set; }
        //public int SectorId { get; set; }
        public SectorEnum Sector { get; set; }
        //public Sector? Sector { get; set; }
    }
}
