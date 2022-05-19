using VehicleMgmt.BusinessService.IBusinessService;
using VehicleMgmt.DataService.RepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.BusinessService.BusinessService
{
    public class VehicleTypeBusiness : BaseCrudBusiness<VehicleTypeModel>, IVehicleTypeBusiness
    {
        internal override BaseCrudRepository<VehicleTypeModel> GetRepository()
        {
            return new VehicleTypeRepository();
        }
    }
}
