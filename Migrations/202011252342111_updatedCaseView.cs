namespace COVID19TriC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedCaseView : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cases", "Location_LocationID", c => c.Int());
            CreateIndex("dbo.Cases", "Location_LocationID");
            AddForeignKey("dbo.Cases", "Location_LocationID", "dbo.Locations", "LocationID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cases", "Location_LocationID", "dbo.Locations");
            DropIndex("dbo.Cases", new[] { "Location_LocationID" });
            DropColumn("dbo.Cases", "Location_LocationID");
        }
    }
}
