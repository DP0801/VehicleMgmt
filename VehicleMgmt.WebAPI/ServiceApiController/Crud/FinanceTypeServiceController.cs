using System.Web.Http;
using VehicleMgmt.BusinessService.BusinessService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.WebAPI.ServiceApiController
{
    public class FinanceTypeServiceController : BaseCrudController<FinanceTypeModel>
    {
        /// <summary>
        /// Get List of records
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/rest/FinanceTypes")]
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
        [Route("api/rest/FinanceTypes")]
        public IHttpActionResult Post([FromBody]FinanceTypeModel obj)
        {
            return BaseCreate(obj);
        }

        internal override BaseCrudBusiness<FinanceTypeModel> GetBusiness()
        {
            return new FinanceTypeBusiness();
        }
    }
}