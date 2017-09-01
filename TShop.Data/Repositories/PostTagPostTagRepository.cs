using TShop.Data.Infrastructure;
using TShop.Model.Models;

namespace TShop.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    { }

    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}