

namespace FielApi.Infrastructure.persistance
{
    public class TicketOrderModel
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public int PositionId { get; set; }
        public int GameId { get; set; }
        public BuyerModel Buyer { get; set; }
        public GameModel Game { get; set; }
        public PositionModel Position { get; set; }
    }
}
