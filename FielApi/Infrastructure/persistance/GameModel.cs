namespace FielApi.Infrastructure.persistance
{
    public class GameModel
    {
        public int Id { get; set; }
        public string? Identificator { get; set; }
        public string? HomeTeam { get; set; }
        public string? AwayTeam { get; set; }
        public string? Competition { get; set; }
    }
}
