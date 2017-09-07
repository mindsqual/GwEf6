using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobSearchTracker.Model
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public AddressType AddressType { get; set; }

        //[ForeignKey("Person")]
        public int ContactPersonId { get; set; }
        
        public virtual ContactPerson Person { get; set; }
    }
}