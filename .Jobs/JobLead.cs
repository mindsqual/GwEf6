using JobSearchTracker.Model.Contacts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace JobSearchTracker.Model.Jobs
{
    public class JobLead
    {
        private ICollection<ContactPerson> _contacts;

        public JobLead()
        {
            _contacts = new List<ContactPerson>();
        }
        
        [Key]
        [Column("Id")]
        public int JobLeadId { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual JobDescription JobDescription { get; set; }
        
        //Nav properties
        public virtual Company Company { get; set; }

        public virtual ICollection<ContactPerson> Contacts
        {
            get { return _contacts as List<ContactPerson>; }
            set { _contacts = value; }
        }

        //TO-DO
        //public virtual ICollection<SearchActivity>

    }
}
