using UnitOfShop.Models;

namespace UnitOfShop.Interfaces
{
    public interface IOrderRepository
    {
        void Save(Order Order);
    }
}
