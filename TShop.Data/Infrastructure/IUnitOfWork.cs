namespace TShop.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}