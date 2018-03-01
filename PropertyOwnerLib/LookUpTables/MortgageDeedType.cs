using System;
using System.Collections.Generic;
using System.Text;

namespace RealCloud.Data
{
    public class MortgageDeedType
    {
        public string MortgageDeedTypeCode { get; set; }
        public string MortgageDeedTypeDescription { get; set; }

        public ICollection<Mortgage> Mortgages { get; set; }
        public ICollection<Mortgage> MortgagesSecond { get; set; }
    }
}
