using System.Collections.Generic;
using JobSearchTracker.Model.Jobs;

namespace JobSearchTracker.Model.Contacts
{
    public class ContactPerson
    {
        private ICollection<Address> _addresses;
        
        public ContactPerson()
        {
            _addresses = new List<Address>();
            
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public virtual ContactDetail ContactDetail { get; set; }

        //[Key, ForeignKey("JobLead")]
        public int JobLeadId { get; set; }
        public virtual ICollection<Address> Addresses
        {
            get { return _addresses; }
            set { _addresses = value; }
        }

        #region//Navigation properties
        //public virtual JobLead JobLead { get; set; } TO-DO: add this later
        #endregion

    }
}
