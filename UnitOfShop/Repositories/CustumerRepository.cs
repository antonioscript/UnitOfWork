using UnitOfShop.Data;
using UnitOfShop.Interfaces;
using UnitOfShop.Models;

namespace UnitOfShop.Repositories
{
    public class CustumerRepository : ICustomerRepository
    {
        private readonly DataContext _context;
        public CustumerRepository(DataContext context)
        {
            _context = context;
        }
        public void Save(Customer customer)
        {
            _context.Customers.Add(customer);
            //_context.SaveChanges(); -> UnitOfWork já faz essa fuñção
        }
    }
}
