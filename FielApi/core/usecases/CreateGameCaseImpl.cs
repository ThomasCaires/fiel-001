using FielApi.core.entities;

namespace FielApi.core.usecases
{
    public class CreateGameCaseImpl : ICreateGameCase
    {
        public Game Execute(string homeTeam, string awayTeam, string competition, string identificator)
        {
            return new Game { HomeTeam = homeTeam, AwayTeam = awayTeam, Competition = competition, Identificator = identificator };
        }
    }
}
