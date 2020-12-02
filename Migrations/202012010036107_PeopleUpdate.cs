namespace COVID19TriC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PeopleUpdate : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.People", "LocationID");
            CreateIndex("dbo.People", "DepartmentID");
            AddForeignKey("dbo.People", "DepartmentID", "dbo.Departments", "DepartmentID", cascadeDelete: true);
            AddForeignKey("dbo.People", "LocationID", "dbo.Locations", "LocationID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "LocationID", "dbo.Locations");
            DropForeignKey("dbo.People", "DepartmentID", "dbo.Departments");
            DropIndex("dbo.People", new[] { "DepartmentID" });
            DropIndex("dbo.People", new[] { "LocationID" });
        }
    }
}
