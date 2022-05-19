namespace VehicleMgmt.DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblFinanceRateTypeValue", "RateValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.tblFinanceRateTypeValue", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblFinanceRateTypeValue", "Name", c => c.String());
            DropColumn("dbo.tblFinanceRateTypeValue", "RateValue");
        }
    }
}
