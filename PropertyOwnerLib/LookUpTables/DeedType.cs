using System.Collections.Generic;

namespace RealCloud.Database.LookupTables
{
    public class DeedType
    {
        public string DeedTypeCode { get; set; }
        public string DeedTypeDescription { get; set; }

        public virtual ICollection<PropertyDetails> Properties { get; set; }
    }
}
