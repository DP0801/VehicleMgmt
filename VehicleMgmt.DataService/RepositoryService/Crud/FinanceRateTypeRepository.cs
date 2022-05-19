using System.Data.Entity;
using VehicleMgmt.DataService.Context;
using VehicleMgmt.DataService.IRepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.DataService.RepositoryService
{
    public class FinanceRateTypeRepository : BaseCrudRepository<FinanceRateTypeModel>, IFinanceRateTypeRepository
    {
        public override FinanceRateTypeModel CreateModel()
        {
            return new FinanceRateTypeModel();
        }
         
        public override DbSet<FinanceRateTypeModel> GetDbSet(VehicleMgmtContext db)
        {
            return db.FinanceRateType;
        }
    }
}
