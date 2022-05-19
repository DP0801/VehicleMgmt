using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleMgmt.Models.Entity
{
    [Table("tblVehicleFinanceDetail")]
    public class VehicleFinanceDetailModel : BaseIdentity
    {
        public int MakeId { get; set; }
        public int VehicleTypeId { get; set; }
        public int FinanceTypeId { get; set; }
        public int FinanceTypeValueId { get; set; }
    }
}
