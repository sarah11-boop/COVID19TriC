namespace COVID19TriC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cases",
                c => new
                    {
                        CaseID = c.Int(nullable: false, identity: true),
                        Quarantined = c.Boolean(nullable: false),
                        DateQuarantineEnds = c.DateTime(nullable: false),
                        CountyNotified = c.Boolean(nullable: false),
                        GeneralComments = c.String(),
                        ExposureComments = c.String(),
                        DateLastAtLocation = c.DateTime(nullable: false),
                        DateOfExposure = c.DateTime(nullable: false),
                        DateOfSymptoms = c.DateTime(nullable: false),
                        DateOfTest = c.DateTime(nullable: false),
                        DateOfDiagnosis = c.DateTime(nullable: false),
                        DateReported = c.DateTime(nullable: false),
                        Symptoms = c.String(),
                        ReportingName = c.String(),
                        ReportingTitle = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                        ReportingDepartmentID = c.Int(nullable: false),
                        TravelRestrictionState = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CaseID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentDescription = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        LocationID = c.Int(nullable: false, identity: true),
                        LocationDescription = c.String(),
                    })
                .PrimaryKey(t => t.LocationID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        SNumber = c.String(),
                        LastName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        PersonalEmail = c.String(),
                        SchoolEmail = c.String(),
                        PhoneNumber = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        ModifiedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusID = c.Int(nullable: false, identity: true),
                        StatusDescription = c.String(),
                    })
                .PrimaryKey(t => t.StatusID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Status");
            DropTable("dbo.People");
            DropTable("dbo.Locations");
            DropTable("dbo.Departments");
            DropTable("dbo.Cases");
        }
    }
}
