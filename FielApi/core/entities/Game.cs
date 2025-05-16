namespace FielApi.core.entities
{
    public class Game
    {
        public int Id { get; set; }
        public string? Identificator { get; set; }
        public string? HomeTeam { get; set; }
        public string? AwayTeam { get; set; }
        public string? Competition { get; set; }
        public decimal Multiplicator { get; set; }
    }
}
