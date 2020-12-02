namespace COVID19TriC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CaseModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cases", "Department_DepartmentID", c => c.Int());
            AddColumn("dbo.Cases", "Location_LocationID", c => c.Int());
            CreateIndex("dbo.Cases", "StatusID");
            CreateIndex("dbo.Cases", "PersonID");
            CreateIndex("dbo.Cases", "Department_DepartmentID");
            CreateIndex("dbo.Cases", "Location_LocationID");
            AddForeignKey("dbo.Cases", "Department_DepartmentID", "dbo.Departments", "DepartmentID");
            AddForeignKey("dbo.Cases", "Location_LocationID", "dbo.Locations", "LocationID");
            AddForeignKey("dbo.Cases", "PersonID", "dbo.People", "PersonID", cascadeDelete: true);
            AddForeignKey("dbo.Cases", "StatusID", "dbo.Status", "StatusID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cases", "StatusID", "dbo.Status");
            DropForeignKey("dbo.Cases", "PersonID", "dbo.People");
            DropForeignKey("dbo.Cases", "Location_LocationID", "dbo.Locations");
            DropForeignKey("dbo.Cases", "Department_DepartmentID", "dbo.Departments");
            DropIndex("dbo.Cases", new[] { "Location_LocationID" });
            DropIndex("dbo.Cases", new[] { "Department_DepartmentID" });
            DropIndex("dbo.Cases", new[] { "PersonID" });
            DropIndex("dbo.Cases", new[] { "StatusID" });
            DropColumn("dbo.Cases", "Location_LocationID");
            DropColumn("dbo.Cases", "Department_DepartmentID");
        }
    }
}
