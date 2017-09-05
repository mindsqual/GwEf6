using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchTracker.Model
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

        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        #region//Navigation properties
        //public virtual ContactDetail ContactDetail { get; set; } //TO-DO: use ContactDetails

        public virtual ICollection<Address> Addresses
        {
            get { return _addresses; }
            set { _addresses = value; }
        }

        #endregion

    }
}
