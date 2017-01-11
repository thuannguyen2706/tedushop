using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;
namespace TeduShop.Data.Repositories
{
    public interface IVisistorStatisticRepository:IRepository<VisistorStatistic>
    {

    }
    public class VisistorStatisticRepository:RepositoryBase<VisistorStatistic>
    {
        public VisistorStatisticRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
