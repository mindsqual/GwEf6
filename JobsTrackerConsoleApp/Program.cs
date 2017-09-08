using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSearchTracker.DataLayer;
using System.Transactions;
using JobSearchTracker.Model;

namespace JobsTrackerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console App. for JobSearchTracker-- 'GwEF6'. ");
            //GetCompanies();
            PopulateAddressTable();
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }

        private static void GetCompanies()
        {
            using (var context = new JobsContext())
            {
                var companies = context.Companies.ToList();
                foreach(var company in companies)
                {
                    Console.WriteLine(company.Name);
                }
            }
        }

        private static void PopulateAddressTable()
        {
            using (TransactionScope transaction = new TransactionScope())

            {

                using (JobsContext db = new JobsContext())
                 {
                    #region//person1
                    //TO-DO:  check whether person exists first...
                    ContactPerson person1=new ContactPerson { FirstName = "Ray", LastName = "Oflite" };
                    db.People.Add(person1);
                    db.SaveChanges();

                    Address person1Addr = new Address { Street = "8 Adams", City = "Detroit", StateProvince = "MI", PostalCode = "01237", ContactPersonId = person1.Id };
                    db.Addresses.Add(person1Addr);
                    #endregion
                    ////////////////////////////////////////
                    
                    #region//person 'Brice'
                    var Brice = db.People.Where(p=>p.FirstName=="Brice").Single();
                    Address personBriceAddr = new Address { Street = "8 Adams", City = "Detroit", StateProvince = "MI", PostalCode = "01237", ContactPersonId = Brice.Id };
                    db.Addresses.Add(personBriceAddr);
                    #endregion

                    try
                    {
                        db.SaveChanges();
                        transaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }
    }
}
