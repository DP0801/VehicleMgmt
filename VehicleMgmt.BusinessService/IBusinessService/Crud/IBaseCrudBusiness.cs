using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicleMgmt.Models.Helper.EnumHandler;

namespace VehicleMgmt.BusinessService.IBusinessService
{
    public interface IBaseCrudBusiness<T> where T : class
    {
        Tuple<List<T>, AccessStatus> Read();
        Tuple<T, AccessStatus> Create(T obj);        
    }
}
