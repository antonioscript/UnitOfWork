using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitOfShop.Interfaces;
using UnitOfShop.Models;
using UnitOfShop.Transaction;

namespace UnitOfShop.Controllers
{
    [Route("v1/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Order Post(
                [FromServices] ICustomerRepository customerRepository,
                [FromServices] IOrderRepository orderRepository,
                [FromServices] IUnitOfWork unity
            )
        {
            try
            {
                var customer = new Customer { Name = "Antônio Rocha" };
                var order = new Order { Number = "123", Custumer = customer };

                customerRepository.Save(customer);
                orderRepository.Save(order);

                unity.Commit();

                return order;

            }catch
            {
                unity.Rollback();
                return null;
            }
        }
    }
}
