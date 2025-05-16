using FielApi.core.constants;

namespace FielApi.core.entities
{
    public class Buyer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public float Points { get; set; }
        public TierRecord Tier { get; set; }
    }
}
