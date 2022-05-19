using System.Web.Http;
using VehicleMgmt.BusinessService.BusinessService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.WebAPI.ServiceApiController
{
    public class VehicleFinanceDetailServiceController : BaseCrudController<VehicleFinanceDetailModel>
    {
        /// <summary>
        /// Get List of records
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/rest/VehicleFinanceDetail")]
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
        [Route("api/rest/VehicleFinanceDetail")]
        public IHttpActionResult Post([FromBody]VehicleFinanceDetailModel obj)
        {
            return BaseCreate(obj);
        }

        internal override BaseCrudBusiness<VehicleFinanceDetailModel> GetBusiness()
        {
            return new VehicleFinanceDetailBusiness();
        }
    }
}