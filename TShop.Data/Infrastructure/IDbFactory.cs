using System;

namespace TShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TShopDbContext Init();
    }
}