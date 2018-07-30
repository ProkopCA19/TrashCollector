namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Email = c.String(),
                        TrashBalance = c.Double(nullable: false),
                        ZipcodeID = c.Int(nullable: false),
                        PickupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.PickupDays", t => t.PickupID, cascadeDelete: true)
                .ForeignKey("dbo.Zipcodes", t => t.ZipcodeID, cascadeDelete: true)
                .Index(t => t.ZipcodeID)
                .Index(t => t.PickupID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "ZipcodeID", "dbo.Zipcodes");
            DropForeignKey("dbo.Customers", "PickupID", "dbo.PickupDays");
            DropIndex("dbo.Customers", new[] { "PickupID" });
            DropIndex("dbo.Customers", new[] { "ZipcodeID" });
            DropTable("dbo.Customers");
        }
    }
}
