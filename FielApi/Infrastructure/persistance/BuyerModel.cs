namespace FielApi.Infrastructure.persistance
{
    public class BuyerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public decimal Points { get; set; }
    }
}
