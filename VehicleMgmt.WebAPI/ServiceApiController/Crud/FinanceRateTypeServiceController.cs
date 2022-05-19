using System.Web.Http;
using VehicleMgmt.BusinessService.BusinessService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.WebAPI.ServiceApiController
{
    public class FinanceRateTypeServiceController : BaseCrudController<FinanceRateTypeModel>
    {
        /// <summary>
        /// Get List of records
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/rest/FinanceRateTypes")]
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
        [Route("api/rest/FinanceRateTypes")]
        public IHttpActionResult Post([FromBody]FinanceRateTypeModel obj)
        {
            return BaseCreate(obj);
        }

        internal override BaseCrudBusiness<FinanceRateTypeModel> GetBusiness()
        {
            return new FinanceRateTypeBusiness();
        }
    }
}