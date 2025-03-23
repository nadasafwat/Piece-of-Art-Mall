using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Piece_of_Art_Mall.DTOs.CustomerDTOs;
using Piece_of_Art_Mall.Repository_Pattern.Customer_Repository;

namespace Piece_of_Art_Mall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer repo;
        public CustomerController(ICustomer repo) {
            this.repo = repo;
        }
        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer(CustomerOnly customer)
        {
            var responce = repo.AddCustomer(customer);
            if (responce.status)
            {
                return Ok(responce);
            }
            else
            {
                return BadRequest(responce);
            }
        }
        [HttpPost("AddCustomerWithLoyalityCard")]
        public IActionResult AddCustomerWithLoyalityCard(CustomerWithLoyalityCard customer)
        {
            var responce = repo.AddCustomerWithLoyalityCard(customer);
            if (responce.status)
            {
                return Ok(responce);
            }
            else
            {
                return BadRequest(responce);
            }
        }


    }
}
