using System.ComponentModel.DataAnnotations;

namespace Piece_of_Art_Mall.DTOs.CustomerDTOs
{
    public class CustomerOnly
    {
        [Required] public string CustomerName { get; set; }
        [EmailAddress] public string CustomerEmail { get; set; }

    }
}
