using FielApi.core.entities;

namespace FielApi.core.usecases
{
    public interface ICreateGameCase
    {
        public Game Execute(string homeTeam, string awayTeam, string competition, string identificator);
    }
}
