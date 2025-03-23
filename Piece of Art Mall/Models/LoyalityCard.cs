namespace Piece_of_Art_Mall.Models
{
    public class LoyalityCard
    {
        public int LoyalityCardId { get; set; }
        public int LoyalityCardBalance { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
