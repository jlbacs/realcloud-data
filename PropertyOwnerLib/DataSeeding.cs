using System;
using System.Linq;

namespace RealCloud.Data
{
    public class DataSeeding
    {
        private PropertyOwnerContext db;

        public DataSeeding(PropertyOwnerContext db)
        {
            this.db = db;
        }

        public void SeedData()
        {
            SeedDeedType();
            SeedRoofType();
            SeedMortgageLoanType();
            SeedMortgageDeedType();
            db.SaveChanges();
        }

        private void SeedMortgageDeedType()
        {
            if (!db.MortgageDeedType.Any())
            {
                db.AddRange(new MortgageDeedType
                {
                    MortgageDeedTypeCode = "10",
                    MortgageDeedTypeDescription = "Simple Mortgage"
                },
                new MortgageDeedType
                {
                    MortgageDeedTypeCode = "20",
                    MortgageDeedTypeDescription = "Mortgage by Conditional Sale"
                },
                new MortgageDeedType
                {
                    MortgageDeedTypeCode = "30",
                    MortgageDeedTypeDescription = "Unsufructuary Mortgage"
                },
                new MortgageDeedType
                {
                    MortgageDeedTypeCode = "40",
                    MortgageDeedTypeDescription = "English Mortgage"
                },
                new MortgageDeedType
                {
                    MortgageDeedTypeCode = "50",
                    MortgageDeedTypeDescription = "Mortgage by Deposit of Title Deeds"
                },
                new MortgageDeedType
                {
                    MortgageDeedTypeCode = "60",
                    MortgageDeedTypeDescription = "Anamolous Mortgage"
                });
            }
        }

        private void SeedMortgageLoanType()
        {
            if (!db.MortgageLoanType.Any())
            {
                db.AddRange(new MortgageLoanType
                {
                    MortgageLoanTypeCode = "10",
                    MortgageLoanTypeDescription = "repayment mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "20",
                    MortgageLoanTypeDescription = "interest-only mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "30",
                    MortgageLoanTypeDescription = "fixed rate mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "40",
                    MortgageLoanTypeDescription = "variable rate mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "50",
                    MortgageLoanTypeDescription = "tracker mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "60",
                    MortgageLoanTypeDescription = "discounted rate mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "70",
                    MortgageLoanTypeDescription = "capped rate mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "80",
                    MortgageLoanTypeDescription = "cashback mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "90",
                    MortgageLoanTypeDescription = "offset mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "100",
                    MortgageLoanTypeDescription = "95% and 100% mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "110",
                    MortgageLoanTypeDescription = "flexible mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "120",
                    MortgageLoanTypeDescription = "first time buyer mortgages"
                },
                new MortgageLoanType
                {
                    MortgageLoanTypeCode = "130",
                    MortgageLoanTypeDescription = "buy to let mortgages"
                });
            }
        }

        private void SeedRoofType()
        {
            if (!db.RoofType.Any())
            {
                db.AddRange(new RoofType
                {
                    RoofTypeCode = "10",
                    RoofTypeDescription = "Spanish Tile"
                },
                new RoofType
                {
                    RoofTypeCode = "20",
                    RoofTypeDescription = "Asphalt"
                },
                new RoofType
                {
                    RoofTypeCode = "30",
                    RoofTypeDescription = "Shingle"
                });
            }
        }

        private void SeedDeedType()
        {
            if (!db.DeedType.Any())
            {
                db.AddRange(new DeedType
                {
                    DeedTypeCode = "10",
                    DeedTypeDescription = "Warranty Deed"
                },
                new DeedType
                {
                    DeedTypeCode = "20",
                    DeedTypeDescription = "Special Warranty Deed"
                },
                new DeedType
                {
                    DeedTypeCode = "30",
                    DeedTypeDescription = "Quitclaim Deed"
                },
                new DeedType
                {
                    DeedTypeCode = "40",
                    DeedTypeDescription = "Bargain and Sale Deed"
                },
                new DeedType
                {
                    DeedTypeCode = "50",
                    DeedTypeDescription = "Grant Deed"
                });
            }
        }
    }
}
