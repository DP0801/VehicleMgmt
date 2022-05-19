using System;
using System.Collections.Generic;
using VehicleMgmt.BusinessService.IBusinessService;
using VehicleMgmt.DataService.RepositoryService;
using static VehicleMgmt.Models.Helper.EnumHandler;

namespace VehicleMgmt.BusinessService.BusinessService
{
    public abstract class BaseCrudBusiness<T> : IBaseCrudBusiness<T> where T : class
    {
        public virtual Tuple<List<T>, AccessStatus> Read()
        {
            var repository = GetRepository();
            return Tuple.Create(repository.Read(AccessType.ALL), AccessStatus.OK);
        }
         
        public virtual Tuple<T, AccessStatus> Create(T obj)
        {
            var repository = GetRepository();
            return repository.Create(obj);
        }
         
        internal abstract BaseCrudRepository<T> GetRepository();
    }
}
