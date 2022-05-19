using System.Data.Entity;
using VehicleMgmt.DataService.Context;
using VehicleMgmt.DataService.IRepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.DataService.RepositoryService
{
    public class FinanceRateTypeValueRepository : BaseCrudRepository<FinanceRateTypeValueModel>, IFinanceRateTypeValueRepository
    {
        public override FinanceRateTypeValueModel CreateModel()
        {
            return new FinanceRateTypeValueModel();
        }
         
        public override DbSet<FinanceRateTypeValueModel> GetDbSet(VehicleMgmtContext db)
        {
            return db.FinanceRateTypeValue;
        }
    }
}
