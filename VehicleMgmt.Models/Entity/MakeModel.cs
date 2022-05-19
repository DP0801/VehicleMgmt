using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleMgmt.Models.Entity
{
    [Table("tblMake")]
    public class MakeModel : BaseIdentity
    {
        public string Name { get; set; }
    }
}
