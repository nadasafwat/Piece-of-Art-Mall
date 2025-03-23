using Piece_of_Art_Mall.DTOs.CustomerDTOs;
using Piece_of_Art_Mall.Resposes;

namespace Piece_of_Art_Mall.Repository_Pattern.Customer_Repository
{
    public interface ICustomer
    {
        public AddResponse AddCustomer(CustomerOnly customer);
        public AddResponse AddCustomerWithLoyalityCard(CustomerWithLoyalityCard customer);


    }
}
