using VehicleMgmt.BusinessService.IBusinessService;
using VehicleMgmt.DataService.RepositoryService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.BusinessService.BusinessService
{
    public class FinanceRateTypeValueBusiness : BaseCrudBusiness<FinanceRateTypeValueModel>, IFinanceRateTypeValueBusiness
    {
        internal override BaseCrudRepository<FinanceRateTypeValueModel> GetRepository()
        {
            return new FinanceRateTypeValueRepository();
        }
    }
}
