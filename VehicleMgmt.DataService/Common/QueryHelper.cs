using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicleMgmt.Models.Helper.EnumHandler;

namespace VehicleMgmt.DataService.Common
{
    public class QueryHelper<T> where T : class
    {
        public static QueryHelper<T> Create()
        {
            return new QueryHelper<T>();
        }

        public IQueryable<T> GetQuery(DbSet<T> dbSet)
        {            
            return dbSet.AsQueryable<T>();
        }           
    }
}
