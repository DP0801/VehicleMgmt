using System.Data.Entity;
using VehicleMgmt.DataService.Context;
using VehicleMgmt.DataService.IRepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.DataService.RepositoryService
{
    public class FinanceTypeRepository : BaseCrudRepository<FinanceTypeModel>, IFinanceTypeRepository
    {
        public override FinanceTypeModel CreateModel()
        {
            return new FinanceTypeModel();
        }

        public override DbSet<FinanceTypeModel> GetDbSet(VehicleMgmtContext db)
        {
            return db.FinanceType;
        }
    }
}
