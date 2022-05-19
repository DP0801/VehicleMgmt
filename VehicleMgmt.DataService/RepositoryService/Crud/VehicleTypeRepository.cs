using System.Data.Entity;
using VehicleMgmt.DataService.Context;
using VehicleMgmt.DataService.IRepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.DataService.RepositoryService
{
    public class VehicleTypeRepository : BaseCrudRepository<VehicleTypeModel>, IVehicleTypeRepository
    {
        public override VehicleTypeModel CreateModel()
        {
            return new VehicleTypeModel();
        }

        public override DbSet<VehicleTypeModel> GetDbSet(VehicleMgmtContext db)
        {
            return db.VehicleType;
        }
    }
}
