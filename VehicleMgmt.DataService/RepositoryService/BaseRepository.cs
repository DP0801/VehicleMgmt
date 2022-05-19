using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMgmt.DataService.Common;
using VehicleMgmt.DataService.Context;
using VehicleMgmt.DataService.IRepositoryService;
using static VehicleMgmt.Models.Helper.EnumHandler;

namespace VehicleMgmt.DataService.RepositoryService
{
    public abstract class BaseCrudRepository<T> : IBaseCrudRepository<T> where T : class
    {
        public abstract DbSet<T> GetDbSet(VehicleMgmtContext db);
        public abstract T CreateModel();
        
        public virtual List<T> Read(AccessType accessType)
        {
            using (var db = new VehicleMgmtContext())
            {
                IQueryable<T> q = QueryHelper<T>.Create().GetQuery(GetDbSet(db));
                return q.ToList();
            }
        }
         
        public virtual Tuple<T, AccessStatus> Create(T obj)
        {
            using (var db = new VehicleMgmtContext())
            {                
                var dbSet = GetDbSet(db);
                dbSet.Add(obj);
                db.SaveChanges();

                return Tuple.Create(obj, AccessStatus.OK);
            }
        }
         
    }
}
