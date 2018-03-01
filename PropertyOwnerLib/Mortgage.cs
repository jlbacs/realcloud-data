using System;

namespace RealCloud.Data
{
    public class Mortgage
    {
        public int MortgageId { get; set; }
        public double? MortgageAssumptionAmount { get; set; }
        public int? MortgageTerm { get; set; }
        public string SecondMortgageDeedTypeCode { get; set; }
        public DateTime? MortgageDate { get; set; }
        public int? PriorMortgageAmount { get; set; }
        public string SecondMortgageLoanTypeCode { get; set; }
        public string MortgageLoanTypeCode { get; set; }
        public double? SecondMortgageAmount { get; set; }
        public DateTime? MortgageDueDate { get; set; }
        public string MortgageDeedTypeCode { get; set; }
        public double? MortgageAmount { get; set; }
        public string MortgageTermCode { get; set; }
        public int? PropertyId { get; set; }

        public virtual MortgageLoanType MortgageLoanType { get; set; }
        public virtual MortgageDeedType MortgageDeedType { get; set; }
        public virtual MortgageLoanType SecondMortgageLoanType { get; set; }
        public virtual MortgageDeedType SecondMortgageDeedType { get; set; }
        public virtual PropertyDetails PropertyDetails { get; set; }
    }
}
