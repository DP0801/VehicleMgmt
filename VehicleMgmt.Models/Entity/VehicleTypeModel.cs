using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleMgmt.Models.Entity
{
    [Table("tblVehicleType")]
    public class VehicleTypeModel : BaseIdentity
    {
        public string MakeId { get; set; }
        public string Name { get; set; }
    }
}
