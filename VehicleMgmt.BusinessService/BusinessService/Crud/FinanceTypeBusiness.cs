using VehicleMgmt.BusinessService.IBusinessService;
using VehicleMgmt.DataService.RepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.BusinessService.BusinessService
{
    public class FinanceTypeBusiness : BaseCrudBusiness<FinanceTypeModel>, IFinanceTypeBusiness
    {
        internal override BaseCrudRepository<FinanceTypeModel> GetRepository()
        {
            return new FinanceTypeRepository();
        }
    }
}
