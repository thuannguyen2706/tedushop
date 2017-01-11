using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
namespace TeduShop.Data.Repositories
{
    public interface IProductTagRepository:IRepository<ProductTag>
    {

    }
    public class ProductTagRepository:RepositoryBase<ProductTag>
    {
        public ProductTagRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
