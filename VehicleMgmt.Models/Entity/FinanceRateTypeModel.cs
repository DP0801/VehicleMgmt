using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleMgmt.Models.Entity
{
    [Table("tblFinanceRateType")]
    public class FinanceRateTypeModel : BaseIdentity
    {
        public string Name { get; set; }
    }
}
