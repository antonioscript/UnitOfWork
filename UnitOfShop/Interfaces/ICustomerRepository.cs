using UnitOfShop.Models;

namespace UnitOfShop.Interfaces
{
    public interface ICustomerRepository
    {
        void Save(Customer Customer);
    }
}
