using System.Collections.Generic;

namespace RealCloud.Database
{
    public class AddressDetails
    {
        public int AddressDetailsId { get; set; }
        public int? AddressKey { get; set; }
        public string Address { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }
        public int? PhoneNumber { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }

        public virtual PropertyDetails Property { get; set; }
        public virtual ICollection<Owner> Owner { get; set; }
    }
}
