using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShop.Data.Infrastructure
{
    public class DbFactory:Disposable,IDbFactory
    {
        TShopDbContext dbContext;
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
