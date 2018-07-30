namespace Trash_Collector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PickupDays",
                c => new
                    {
                        PickupID = c.Int(nullable: false, identity: true),
                        Charge = c.Double(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PickupID);
            
            CreateTable(
                "dbo.Zipcodes",
                c => new
                    {
                        ZipcodeId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ZipcodeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zipcodes");
            DropTable("dbo.PickupDays");
        }
    }
}
