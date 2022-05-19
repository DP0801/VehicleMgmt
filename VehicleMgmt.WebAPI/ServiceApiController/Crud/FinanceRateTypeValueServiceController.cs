using System.Web.Http;
using VehicleMgmt.BusinessService.BusinessService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.WebAPI.ServiceApiController
{
    public class FinanceRateTypeValueServiceController : BaseCrudController<FinanceRateTypeValueModel>
    {
        /// <summary>
        /// Get List of records
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/rest/FinanceRateTypeValues")]
        public IHttpActionResult Get()
        {
            return BaseRead();
        }

        /// <summary>
        /// Add record
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/rest/FinanceRateTypeValues")]
        public IHttpActionResult Post([FromBody]FinanceRateTypeValueModel obj)
        {
            return BaseCreate(obj);
        }

        internal override BaseCrudBusiness<FinanceRateTypeValueModel> GetBusiness()
        {
            return new FinanceRateTypeValueBusiness();
        }
    }
}