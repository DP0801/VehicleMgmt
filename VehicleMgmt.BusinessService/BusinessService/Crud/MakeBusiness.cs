using VehicleMgmt.BusinessService.IBusinessService;
using VehicleMgmt.DataService.RepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.BusinessService.BusinessService
{
    public class MakeBusiness : BaseCrudBusiness<MakeModel>, IMakeBusiness
    {
        internal override BaseCrudRepository<MakeModel> GetRepository()
        {
            return new MakeRepository();
        }
    }
}
