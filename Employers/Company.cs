using System.Collections.Generic;

namespace JobSearchTracker.Model.Employers
{
    public class Company
    {
        //private ICollection<JobLead> _associatedLeads;

        public Company()
        {
            //_associatedLeads = new List<JobLead>();
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Nav
        //public virtual List<JobLead> AssociatedLeads { get; set; }
    }
}