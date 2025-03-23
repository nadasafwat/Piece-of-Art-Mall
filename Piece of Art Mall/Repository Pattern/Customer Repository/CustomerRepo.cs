using Piece_of_Art_Mall.AppDbContextFolder;
using Piece_of_Art_Mall.DTOs.CustomerDTOs;
using Piece_of_Art_Mall.Models;
using Piece_of_Art_Mall.Resposes;

namespace Piece_of_Art_Mall.Repository_Pattern.Customer_Repository
{
    public class CustomerRepo : ICustomer
    {
        private readonly AppDbContext context;
        public CustomerRepo(AppDbContext context)
        {
            this.context = context;
        }
        public AddResponse AddCustomer(CustomerOnly customer)
        {
            var customername = context.Customer.FirstOrDefault(x => x.CustomerName == customer.CustomerName);
            if (customername != null)
            {
                return new AddResponse { status = false, message = "Customer already exists" };
            }
            else
            {
                var customerEmail = context.Customer.FirstOrDefault(x => x.CustomerEmail == customer.CustomerEmail);
                if (customerEmail != null)
                {
                    return new AddResponse { status = false, message = "Customer already exists" };
                }
                else
                {
                    var newCustomer = new Customer
                    {
                        CustomerName = customer.CustomerName,
                        CustomerEmail = customer.CustomerEmail
                    };
                    context.Customer.Add(newCustomer);
                    context.SaveChanges();
                    return new AddResponse { status = true, message = "Customer added successfully" };
                }
            }
        }

        public AddResponse AddCustomerWithLoyalityCard(CustomerWithLoyalityCard customer)
        {
            var customername = context.Customer.FirstOrDefault(x => x.CustomerName == customer.CustomerName);
            if (customername != null)
            {
                return new AddResponse { status = false, message = "Customer already exists" };
            }
            else
            {
                var customerEmail = context.Customer.FirstOrDefault(x => x.CustomerEmail == customer.CustomerEmail);
                if (customerEmail != null)
                {
                    return new AddResponse { status = false, message = "Customer already exists" };
                }
                else
                {
                    var newCustomer = new Customer
                    {
                        CustomerName = customer.CustomerName,
                        CustomerEmail = customer.CustomerEmail,
                        LoyalityCard = new LoyalityCard
                        {
                            LoyalityCardBalance = customer.LoyalityOnly.LoyalityCardBalance
                        },
                    };
                    context.Customer.Add(newCustomer);
                    context.SaveChanges();
                    return new AddResponse { status = true, message = "Customer added successfully" };
                }
            }
        }
    }
}
