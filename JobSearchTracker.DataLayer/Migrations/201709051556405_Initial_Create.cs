namespace JobSearchTracker.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        StateProvince = c.String(),
                        PostalCode = c.String(),
                        AddressType = c.Int(nullable: false),
                        ContactPersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressId)
                .ForeignKey("dbo.ContactPersons", t => t.ContactPersonId, cascadeDelete: true)
                .Index(t => t.ContactPersonId);
            
            CreateTable(
                "dbo.ContactPersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        JobLeadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JobLeads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedOn = c.DateTime(nullable: false),
                        JobDescription_JobDescriptionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobDescriptions", t => t.JobDescription_JobDescriptionId)
                .Index(t => t.JobDescription_JobDescriptionId);
            
            CreateTable(
                "dbo.JobDescriptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobTitle = c.String(nullable: false, maxLength: 255),
                        Summary = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JobSearchActivities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactPersonId = c.Int(nullable: false),
                        JobLeadId = c.Int(nullable: false),
                        HappenedOn = c.DateTime(nullable: false),
                        JobSearchActivityType = c.Int(nullable: false),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .ForeignKey("dbo.ContactPersons", t => t.ContactPersonId, cascadeDelete: true)
                .ForeignKey("dbo.JobLeads", t => t.JobLeadId, cascadeDelete: true)
                .Index(t => t.ContactPersonId)
                .Index(t => t.JobLeadId)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobSearchActivities", "JobLeadId", "dbo.JobLeads");
            DropForeignKey("dbo.JobSearchActivities", "ContactPersonId", "dbo.ContactPersons");
            DropForeignKey("dbo.JobSearchActivities", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.JobLeads", "JobDescription_JobDescriptionId", "dbo.JobDescriptions");
            DropForeignKey("dbo.Addresses", "ContactPersonId", "dbo.ContactPersons");
            DropIndex("dbo.JobSearchActivities", new[] { "CompanyId" });
            DropIndex("dbo.JobSearchActivities", new[] { "JobLeadId" });
            DropIndex("dbo.JobSearchActivities", new[] { "ContactPersonId" });
            DropIndex("dbo.JobLeads", new[] { "JobDescription_JobDescriptionId" });
            DropIndex("dbo.Addresses", new[] { "ContactPersonId" });
            DropTable("dbo.JobSearchActivities");
            DropTable("dbo.JobDescriptions");
            DropTable("dbo.JobLeads");
            DropTable("dbo.Companies");
            DropTable("dbo.ContactPersons");
            DropTable("dbo.Addresses");
        }
    }
}
