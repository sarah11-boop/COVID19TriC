namespace COVID19TriC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class descriptionreferences : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cases", "StatusID");
            CreateIndex("dbo.Cases", "PersonID");
            AddForeignKey("dbo.Cases", "PersonID", "dbo.People", "PersonID", cascadeDelete: true);
            AddForeignKey("dbo.Cases", "StatusID", "dbo.Status", "StatusID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cases", "StatusID", "dbo.Status");
            DropForeignKey("dbo.Cases", "PersonID", "dbo.People");
            DropIndex("dbo.Cases", new[] { "PersonID" });
            DropIndex("dbo.Cases", new[] { "StatusID" });
        }
    }
}
