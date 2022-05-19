using VehicleMgmt.BusinessService.IBusinessService;
using VehicleMgmt.DataService.RepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.BusinessService.BusinessService
{
    public class FinanceRateTypeBusiness : BaseCrudBusiness<FinanceRateTypeModel>, IFinanceRateTypeBusiness
    {
        internal override BaseCrudRepository<FinanceRateTypeModel> GetRepository()
        {
            return new FinanceRateTypeRepository();
        }
    }
}
