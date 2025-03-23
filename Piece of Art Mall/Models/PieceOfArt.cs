using System.ComponentModel.DataAnnotations;

namespace Piece_of_Art_Mall.Models
{
    public class PieceOfArt
    {
       [Key] public int PieceOfArtId { get; set; }
        [Required] public string PieceOfArtTitle { get; set; }
        [Required] public string PieceOfArtDescription { get; set; }
        [Required] public string PieceOfArtPrice { get; set; }
        public int CategoryId { get; set; }
        public Category category { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
