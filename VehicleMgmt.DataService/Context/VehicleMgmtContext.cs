using System;
using System.Data.Entity;
using VehicleMgmt.Models.Entity;

namespace VehicleMgmt.DataService.Context
{
    public class VehicleMgmtContext : DbContext
    {
        public VehicleMgmtContext() : base("VehicleMgmtConnectionString")
        {
        }

        public DbSet<MakeModel> Make { get; set; }
        public DbSet<VehicleTypeModel> VehicleType { get; set; }
        public DbSet<FinanceTypeModel> FinanceType { get; set; }
        public DbSet<FinanceRateTypeModel> FinanceRateType { get; set; }
        public DbSet<FinanceRateTypeValueModel> FinanceRateTypeValue { get; set; }
        public DbSet<VehicleFinanceDetailModel> VehicleFinanceDetail { get; set; }

        public DbSet Set(string name)
        {
            // you may need to fill in the namespace of your context
            return base.Set(Type.GetType(name));
        }
    }
}
