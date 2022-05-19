namespace VehicleMgmt.DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblFinanceRateType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblFinanceRateTypeValue",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FinanceRateTypeId = c.Int(nullable: false),
                        Name = c.String(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblFinanceType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblMake",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedBy = c.Int(nullable: false),
                        CreatedAt = c.DateTime(),
                        UpdatedBy = c.Int(),
                        UpdatedAt = c.DateTime(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblVehicleType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MakeId = c.String(),
                        Name = c.String(),
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
            DropTable("dbo.tblVehicleType");
            DropTable("dbo.tblMake");
            DropTable("dbo.tblFinanceType");
            DropTable("dbo.tblFinanceRateTypeValue");
            DropTable("dbo.tblFinanceRateType");
        }
    }
}
