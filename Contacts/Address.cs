
namespace JobSearchTracker.Model.Contacts
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public AddressType AddressType { get; set; }
        public int ContactPersonId { get; set; }

        public virtual ContactPerson Person { get; set; }
    }
}