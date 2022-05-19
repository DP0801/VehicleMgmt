using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using VehicleMgmt.BusinessService.BusinessService;
using static VehicleMgmt.Models.Helper.EnumHandler;
using VehicleMgmt.Models.Model;

namespace VehicleMgmt.WebAPI.ServiceApiController
{
    abstract public class BaseCrudController<T> : ApiController where T : class
    {
        internal IHttpActionResult BaseRead()
        {
            var response = new APIResponse();
            try
            {
                BaseCrudBusiness<T> business = GetBusiness();
                var (records, status) = business.Read();
                response.Success = status == AccessStatus.OK;
                response.Message = status.ToString();
                response.Data = records;

            }
            catch (Exception ex)
            {
                
            }
            return Content(HttpStatusCode.OK, response);
        }

        internal IHttpActionResult BaseCreate([FromBody]T obj)
        {
            var response = new APIResponse();

            try
            {
                BaseCrudBusiness<T> business = GetBusiness();
                var (record, status) = business.Create(obj);
                response.Success = status == AccessStatus.OK;
                response.Message = status.ToString();
                response.Data = status == AccessStatus.OK ? new List<T> { record } : null;
            }
            catch (Exception ex)
            {
                
            }

            return Content(HttpStatusCode.OK, response);
        }

        internal abstract BaseCrudBusiness<T> GetBusiness();
    }
}