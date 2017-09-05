using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSearchTracker.DataLayer;


namespace JobsTrackerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCompanies();
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
    }
}
