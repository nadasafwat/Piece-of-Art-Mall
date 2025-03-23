using Piece_of_Art_Mall.DTOs.CustomerDTOs;
using System.ComponentModel.DataAnnotations;

namespace Piece_of_Art_Mall.Models
{
    public class Customer
    { 
        [Key]  public int CustomerId { get; set; }
        [Required]public string CustomerName { get; set; }
        [EmailAddress]public string CustomerEmail { get; set; }
        public LoyalityCard LoyalityCard { get; set; }
        public List<PieceOfArt> PieceOfArts { get; set; } = new List<PieceOfArt>();
    }
}
