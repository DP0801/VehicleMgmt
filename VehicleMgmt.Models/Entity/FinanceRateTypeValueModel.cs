using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleMgmt.Models.Entity
{
    [Table("tblFinanceRateTypeValue")]
    public class FinanceRateTypeValueModel : BaseIdentity
    {
        public Int32 FinanceRateTypeId { get; set; }
        public decimal RateValue { get; set; }
    }
}
