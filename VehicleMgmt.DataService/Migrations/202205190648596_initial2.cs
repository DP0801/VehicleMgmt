namespace VehicleMgmt.DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblVehicleFinanceDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MakeId = c.Int(nullable: false),
                        VehicleTypeId = c.Int(nullable: false),
                        FinanceTypeId = c.Int(nullable: false),
                        FinanceTypeValueId = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblVehicleFinanceDetail");
        }
    }
}
