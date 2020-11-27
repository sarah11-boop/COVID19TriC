namespace COVID19TriC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationcorrectpersonmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "LocationID", c => c.Int(nullable: false));
            AddColumn("dbo.People", "DepartmentID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "DepartmentID");
            DropColumn("dbo.People", "LocationID");
        }
    }
}
