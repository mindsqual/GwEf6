using JobSearchTracker.Model;
namespace JobSearchTracker.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<JobSearchTracker.DataLayer.JobsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JobSearchTracker.DataLayer.JobsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.People.AddOrUpdate(
              p => p.FirstName,
              new ContactPerson { FirstName = "Andrew", LastName= "Peters" },
              new ContactPerson { FirstName = "Brice", LastName= "Lambson" },
              new ContactPerson { FirstName = "Rowan", LastName="Miller" },
              new ContactPerson { FirstName = "Ray", LastName = "Oflite" }
            );

            context.Companies.AddOrUpdate(
                c=>c.Name,
                new Company { Name = "XYZ Company", Description = "We don't mind being last." },
                new Company { Name = "Alph and Beta", Description = "We mind being last." }
            );

            context.Addresses.AddOrUpdate(
                a=>a.Street,
                new Address { Street="7 Adams",City="Boston", ContactPersonId=1, StateProvince="MA", PostalCode= "01234"},
                new Address { Street = "8 Adams", City = "Detroit", ContactPersonId = 2, StateProvince = "MI", PostalCode = "01237" }
                );

        }
    }
}
