using System.Data.Entity;
using JobSearchTracker.Model;

namespace JobSearchTracker.DataLayer
{
    public class JobsContext : DbContext
    {
        public JobsContext():base("JobSearch")
        {
            //Database.SetInitializer<JobsContext>(new CreateDatabaseIfNotExists<JobsContext>());

            //other initiallizers
            Database.SetInitializer<JobsContext>(new DropCreateDatabaseIfModelChanges<JobsContext>());
            //Database.SetInitializer<JobsContext>(new DropCreateDatabaseAlways<JobsContext>());
            //Database.SetInitializer<JobsContext>(new JobsDBInitializer());
        }

        //public DbSet<JobLead> JobLeads { get; set; }  //TO-DO: make job lead a view. Or, have a way to represent it in the client...
        public DbSet<JobSearchActivity> JobSearchActivities { get; set; }
        public DbSet<JobDescription> Jobs { get; set; }
        public DbSet<ContactPerson> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
