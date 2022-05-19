using System.Web.Http;
using VehicleMgmt.BusinessService.BusinessService;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.WebAPI.ServiceApiController
{
    public class MakeServiceController : BaseCrudController<MakeModel>
    {
        /// <summary>
        /// Get List of records
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/rest/Makes")]
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
        [Route("api/rest/Makes")]
        public IHttpActionResult Post([FromBody]MakeModel obj)
        {
            return BaseCreate(obj);
        }

        internal override BaseCrudBusiness<MakeModel> GetBusiness()
        {
            return new MakeBusiness();
        }
    }
}