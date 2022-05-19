using System.Data.Entity;
using VehicleMgmt.DataService.Context;
using VehicleMgmt.DataService.IRepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.DataService.RepositoryService
{
    public class MakeRepository : BaseCrudRepository<MakeModel>, IMakeRepository
    {
        public override MakeModel CreateModel()
        {
            return new MakeModel();
        }
         
        public override DbSet<MakeModel> GetDbSet(VehicleMgmtContext db)
        {
            return db.Make;
        }
    }
}
