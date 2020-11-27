namespace COVID19TriC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class casetablenameannotations : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cases", name: "Quarantined", newName: "Quarantined?");
            RenameColumn(table: "dbo.Cases", name: "DateQuarantineEnds", newName: "Date Quarantine Ends");
            RenameColumn(table: "dbo.Cases", name: "CountyNotified", newName: "County Notified?");
            RenameColumn(table: "dbo.Cases", name: "GeneralComments", newName: "General Comments");
            RenameColumn(table: "dbo.Cases", name: "ExposureComments", newName: "Exposure Comments");
            RenameColumn(table: "dbo.Cases", name: "DateLastAtLocation", newName: "Date Last at Location");
            RenameColumn(table: "dbo.Cases", name: "DateOfExposure", newName: "Date of Exposure");
            RenameColumn(table: "dbo.Cases", name: "DateOfSymptoms", newName: "Date of Symptoms");
            RenameColumn(table: "dbo.Cases", name: "DateOfTest", newName: "Date of Test");
            RenameColumn(table: "dbo.Cases", name: "DateOfDiagnosis", newName: "Date of Diagnosis");
            RenameColumn(table: "dbo.Cases", name: "DateReported", newName: "Date Reported");
            RenameColumn(table: "dbo.Cases", name: "ReportingName", newName: "Reporting Name");
            RenameColumn(table: "dbo.Cases", name: "ReportingTitle", newName: "Reporting Title");
            RenameColumn(table: "dbo.Cases", name: "DateCreated", newName: "Date Created");
            RenameColumn(table: "dbo.Cases", name: "DateModified", newName: "Date Modified");
            RenameColumn(table: "dbo.Cases", name: "CreatedBy", newName: "Created By");
            RenameColumn(table: "dbo.Cases", name: "ModifiedBy", newName: "Modified By");
            RenameColumn(table: "dbo.Cases", name: "TravelRestrictionState", newName: "Travel Restriction State");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Cases", name: "Travel Restriction State", newName: "TravelRestrictionState");
            RenameColumn(table: "dbo.Cases", name: "Modified By", newName: "ModifiedBy");
            RenameColumn(table: "dbo.Cases", name: "Created By", newName: "CreatedBy");
            RenameColumn(table: "dbo.Cases", name: "Date Modified", newName: "DateModified");
            RenameColumn(table: "dbo.Cases", name: "Date Created", newName: "DateCreated");
            RenameColumn(table: "dbo.Cases", name: "Reporting Title", newName: "ReportingTitle");
            RenameColumn(table: "dbo.Cases", name: "Reporting Name", newName: "ReportingName");
            RenameColumn(table: "dbo.Cases", name: "Date Reported", newName: "DateReported");
            RenameColumn(table: "dbo.Cases", name: "Date of Diagnosis", newName: "DateOfDiagnosis");
            RenameColumn(table: "dbo.Cases", name: "Date of Test", newName: "DateOfTest");
            RenameColumn(table: "dbo.Cases", name: "Date of Symptoms", newName: "DateOfSymptoms");
            RenameColumn(table: "dbo.Cases", name: "Date of Exposure", newName: "DateOfExposure");
            RenameColumn(table: "dbo.Cases", name: "Date Last at Location", newName: "DateLastAtLocation");
            RenameColumn(table: "dbo.Cases", name: "Exposure Comments", newName: "ExposureComments");
            RenameColumn(table: "dbo.Cases", name: "General Comments", newName: "GeneralComments");
            RenameColumn(table: "dbo.Cases", name: "County Notified?", newName: "CountyNotified");
            RenameColumn(table: "dbo.Cases", name: "Date Quarantine Ends", newName: "DateQuarantineEnds");
            RenameColumn(table: "dbo.Cases", name: "Quarantined?", newName: "Quarantined");
        }
    }
}
