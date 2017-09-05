namespace JobSearchTracker.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobLead_Has_Person : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.JobLeads", "ContactPersonId", c => c.Int(nullable: false));
            DropColumn("dbo.ContactPersons", "JobLeadId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContactPersons", "JobLeadId", c => c.Int(nullable: false));
            DropColumn("dbo.JobLeads", "ContactPersonId");
        }
    }
}
