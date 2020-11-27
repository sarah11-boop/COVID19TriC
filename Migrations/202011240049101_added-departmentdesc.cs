namespace COVID19TriC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddepartmentdesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cases", "Department_DepartmentID", c => c.Int());
            CreateIndex("dbo.Cases", "Department_DepartmentID");
            AddForeignKey("dbo.Cases", "Department_DepartmentID", "dbo.Departments", "DepartmentID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cases", "Department_DepartmentID", "dbo.Departments");
            DropIndex("dbo.Cases", new[] { "Department_DepartmentID" });
            DropColumn("dbo.Cases", "Department_DepartmentID");
        }
    }
}
