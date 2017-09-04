namespace TShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TShopDbContext dbContext;

        public TShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}