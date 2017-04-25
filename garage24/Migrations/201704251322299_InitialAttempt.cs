namespace garage24.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialAttempt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VType = c.Int(nullable: false),
                        RegNr = c.String(),
                        Color = c.String(),
                        Brand = c.String(),
                        VName = c.String(),
                        WheelTally = c.Int(nullable: false),
                        CheckInTime = c.DateTime(nullable: false),
                        CheckOutTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicles");
        }
    }
}
