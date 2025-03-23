using Piece_of_Art_Mall.DTOs.LoyalityCardDTOs;
using System.ComponentModel.DataAnnotations;

namespace Piece_of_Art_Mall.DTOs.CustomerDTOs
{
    public class CustomerWithAll
    {
      
        [Required] public string CustomerName { get; set; }
        [EmailAddress] public string CustomerEmail { get; set; }
        public LoyalityOnly LoyalityOnly { get; set; }


    }
}
