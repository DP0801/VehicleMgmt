using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMgmt.DataService.Context;
using VehicleMgmt.Models.Helper;
using static VehicleMgmt.Models.Helper.EnumHandler;

namespace VehicleMgmt.DataService.IRepositoryService
{
    public interface IBaseCrudRepository<T> where T : class
    {
        List<T> Read(AccessType accessType);
        
        Tuple<T, AccessStatus> Create(T obj);
        
        DbSet<T> GetDbSet(VehicleMgmtContext db);
                         
        T CreateModel();
    }
}
