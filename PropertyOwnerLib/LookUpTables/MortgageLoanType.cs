using System;
using System.Collections.Generic;
using System.Text;

namespace RealCloud.Data
{
    public class MortgageLoanType
    {
        public string MortgageLoanTypeCode { get; set; }
        public string MortgageLoanTypeDescription { get; set; }

        public ICollection<Mortgage> Mortgages { get; set; }
        public ICollection<Mortgage> MortgagesSecond { get; set; }
    }
}
