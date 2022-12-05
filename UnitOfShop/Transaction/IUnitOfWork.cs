namespace UnitOfShop.Transaction
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
