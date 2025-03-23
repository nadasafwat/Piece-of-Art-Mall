using System.ComponentModel.DataAnnotations;

namespace Piece_of_Art_Mall.Models
{
    public class Category
    {
       [Key]public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<PieceOfArt> PieceOfArts { get; set; } = new List<PieceOfArt>();

    }
}
