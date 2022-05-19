using System.Data.Entity;
using VehicleMgmt.DataService.Context;
using VehicleMgmt.DataService.IRepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.DataService.RepositoryService
{
    public class VehicleFinanceDetailRepository : BaseCrudRepository<VehicleFinanceDetailModel>, IVehicleFinanceDetailRepository
    {
        public override VehicleFinanceDetailModel CreateModel()
        {
            return new VehicleFinanceDetailModel();
        }

        public override DbSet<VehicleFinanceDetailModel> GetDbSet(VehicleMgmtContext db)
        {
            return db.VehicleFinanceDetail;
        }
    }
}
