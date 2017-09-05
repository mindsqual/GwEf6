
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace JobSearchTracker.Model
{
    public class JobLead
    {
        private ICollection<ContactPerson> _contacts;

        //private JobSearchActivity _initialAction;
        public JobLead()
        {
            //_contacts = new List<ContactPerson>();
        }
        
        [Key]
        [Column("Id")]
        public int JobLeadId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ContactPersonId { get; set; }

        //Nav properties
        public virtual JobDescription JobDescription { get; set; }
        public virtual ICollection<JobSearchActivity> SearchActivity { get; set; }
        //public virtual ICollection<ContactPerson> Contacts
        //{
        //    get { return _contacts as List<ContactPerson>; }
        //    set { _contacts = value; }
        //}
        

    }
}
