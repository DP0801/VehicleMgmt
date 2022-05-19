using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleMgmt.Models.Entity
{
    [Table("tblFinanceType")]
    public class FinanceTypeModel : BaseIdentity
    {
        public string Name { get; set; }
    }
}