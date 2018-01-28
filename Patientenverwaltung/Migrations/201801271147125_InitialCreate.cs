namespace Patientenverwaltung.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HealthInsurances",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 128),
                        InsuranceID = c.Int(nullable: false),
                        Street = c.String(),
                        StreetNumber = c.Int(nullable: false),
                        Postalcode = c.Int(nullable: false),
                        City = c.String(),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Name);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        FirstName = c.String(nullable: false, maxLength: 128),
                        SecondName = c.String(nullable: false, maxLength: 128),
                        Birthday = c.DateTime(nullable: false),
                        Street = c.String(),
                        StreetNumber = c.Int(nullable: false),
                        Postalcode = c.Int(nullable: false),
                        City = c.String(),
                        InsuranceID = c.Int(nullable: false),
                        Phonenumber = c.Int(nullable: false),
                        HealthInsurance_Name = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.FirstName, t.SecondName, t.Birthday })
                .ForeignKey("dbo.HealthInsurances", t => t.HealthInsurance_Name)
                .Index(t => t.HealthInsurance_Name);
            
            CreateTable(
                "dbo.Treatments",
                c => new
                    {
                        Date = c.DateTime(nullable: false),
                        Number = c.Int(nullable: false),
                        Description = c.String(),
                        Other = c.String(),
                        Patient_FirstName = c.String(maxLength: 128),
                        Patient_SecondName = c.String(maxLength: 128),
                        Patient_Birthday = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.Date, t.Number })
                .ForeignKey("dbo.Patients", t => new { t.Patient_FirstName, t.Patient_SecondName, t.Patient_Birthday })
                .Index(t => new { t.Patient_FirstName, t.Patient_SecondName, t.Patient_Birthday });
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Treatments", new[] { "Patient_FirstName", "Patient_SecondName", "Patient_Birthday" }, "dbo.Patients");
            DropForeignKey("dbo.Patients", "HealthInsurance_Name", "dbo.HealthInsurances");
            DropIndex("dbo.Treatments", new[] { "Patient_FirstName", "Patient_SecondName", "Patient_Birthday" });
            DropIndex("dbo.Patients", new[] { "HealthInsurance_Name" });
            DropTable("dbo.Users");
            DropTable("dbo.Treatments");
            DropTable("dbo.Patients");
            DropTable("dbo.HealthInsurances");
        }
    }
}
