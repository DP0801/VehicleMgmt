using VehicleMgmt.BusinessService.IBusinessService;
using VehicleMgmt.DataService.RepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.BusinessService.BusinessService
{
    public class VehicleFinanceDetailBusiness : BaseCrudBusiness<VehicleFinanceDetailModel>, IVehicleFinanceDetailBusiness
    {
        internal override BaseCrudRepository<VehicleFinanceDetailModel> GetRepository()
        {
            return new VehicleFinanceDetailRepository();
        }
    }
}
