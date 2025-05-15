namespace FielApi.core.entities
{
    public class TicketOrder
    {
        public int Id { get; set; }
        //public int BuyerId { get; set; }
        //public int PositionId { get; set; }
        //public int MatchId { get; set; }
        public Buyer Buyer { get; set; }
        public Game Game { get; set; }
        public Position Position { get; set; }
    }
}
