namespace Patientenverwaltung.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HealthInsurances", "InsuranceID", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HealthInsurances", "InsuranceID", c => c.Int(nullable: false));
        }
    }
}
