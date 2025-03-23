using Piece_of_Art_Mall.DTOs.CustomerDTOs;
using System.ComponentModel.DataAnnotations;

namespace Piece_of_Art_Mall.DTOs.LoyalityCardDTOs
{
    public class LoyalityWithCustomer
    {
        public int LoyalityCardBalance { get; set; }
        [Required] public string CustomerName { get; set; }
        [EmailAddress] public string CustomerEmail { get; set; }
        public int CustomerId { get; set; }



    }
}
