using System.Collections.Generic;

namespace RealCloud.Database
{
    public class Owner
    {        
        public int OwnerId { get; set; }
        public string OwnerMatchCode { get; set; }
        public string OwnerName { get; set; }
        public string OwnerName2 { get; set; }
        public string AbsenteeOwnerCode { get; set; }
        public bool? CorporateOwner { get; set; }
        public string OwnerCarrierRoute { get; set; }
        public string OwnerSuite { get; set; }
        public string OwnerUnparsedName1 { get; set; }
        public string OwnerUnparsedName2 { get; set; }
        public bool? OwnerMailOptOut { get; set; }
        public bool? OwnerPhoneOptOut { get; set; }

        public int? AddressDetailsId { get; set; }
        public virtual AddressDetails OwnerCurrentAddress { get; set; }

        public virtual ICollection<Property_Owner> PropertyOwner { get; set; }
    }
}
