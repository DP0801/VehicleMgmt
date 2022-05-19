using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.DataService.IRepositoryService
{
    public interface IVehicleTypeRepository : IBaseCrudRepository<VehicleTypeModel>
    {
    }
}
