namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ZipcodeID = c.Int(nullable: false),
                        PickupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.PickupDays", t => t.PickupID, cascadeDelete: true)
                .ForeignKey("dbo.Zipcodes", t => t.ZipcodeID, cascadeDelete: true)
                .Index(t => t.ZipcodeID)
                .Index(t => t.PickupID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "ZipcodeID", "dbo.Zipcodes");
            DropForeignKey("dbo.Employees", "PickupID", "dbo.PickupDays");
            DropIndex("dbo.Employees", new[] { "PickupID" });
            DropIndex("dbo.Employees", new[] { "ZipcodeID" });
            DropTable("dbo.Employees");
        }
    }
}
