namespace JobSearchTracker.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobLead_Dropped_Frm_Model : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.JobLeads", "JobDescription_JobDescriptionId", "dbo.JobDescriptions");
            DropForeignKey("dbo.JobSearchActivities", "JobLeadId", "dbo.JobLeads");
            DropIndex("dbo.JobLeads", new[] { "JobDescription_JobDescriptionId" });
            DropIndex("dbo.JobSearchActivities", new[] { "JobLeadId" });
            DropTable("dbo.JobLeads");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.JobLeads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(nullable: false),
                        ContactPersonId = c.Int(nullable: false),
                        JobDescription_JobDescriptionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.JobSearchActivities", "JobLeadId");
            CreateIndex("dbo.JobLeads", "JobDescription_JobDescriptionId");
            AddForeignKey("dbo.JobSearchActivities", "JobLeadId", "dbo.JobLeads", "Id", cascadeDelete: true);
            AddForeignKey("dbo.JobLeads", "JobDescription_JobDescriptionId", "dbo.JobDescriptions", "Id");
        }
    }
}
