namespace COVID19TriC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cases", "GeneralComments", c => c.String(nullable: false));
            AlterColumn("dbo.Cases", "ExposureComments", c => c.String(nullable: false));
            AlterColumn("dbo.Cases", "Symptoms", c => c.String(nullable: false));
            AlterColumn("dbo.Cases", "ReportingName", c => c.String(nullable: false));
            AlterColumn("dbo.Cases", "ReportingTitle", c => c.String(nullable: false));
            AlterColumn("dbo.Departments", "DepartmentDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "LocationDescription", c => c.String(nullable: false));
            AlterColumn("dbo.People", "SNumber", c => c.String(nullable: false));
            AlterColumn("dbo.People", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.People", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.People", "MiddleName", c => c.String(nullable: false));
            AlterColumn("dbo.People", "PersonalEmail", c => c.String(nullable: false));
            AlterColumn("dbo.People", "SchoolEmail", c => c.String(nullable: false));
            AlterColumn("dbo.People", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Status", "StatusDescription", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Status", "StatusDescription", c => c.String());
            AlterColumn("dbo.People", "PhoneNumber", c => c.String());
            AlterColumn("dbo.People", "SchoolEmail", c => c.String());
            AlterColumn("dbo.People", "PersonalEmail", c => c.String());
            AlterColumn("dbo.People", "MiddleName", c => c.String());
            AlterColumn("dbo.People", "FirstName", c => c.String());
            AlterColumn("dbo.People", "LastName", c => c.String());
            AlterColumn("dbo.People", "SNumber", c => c.String());
            AlterColumn("dbo.Locations", "LocationDescription", c => c.String());
            AlterColumn("dbo.Departments", "DepartmentDescription", c => c.String());
            AlterColumn("dbo.Cases", "ReportingTitle", c => c.String());
            AlterColumn("dbo.Cases", "ReportingName", c => c.String());
            AlterColumn("dbo.Cases", "Symptoms", c => c.String());
            AlterColumn("dbo.Cases", "ExposureComments", c => c.String());
            AlterColumn("dbo.Cases", "GeneralComments", c => c.String());
        }
    }
}
