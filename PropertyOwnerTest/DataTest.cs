using System;
using System.Collections.Generic;
using System.Text;
using RealCloud.Database;
using RealCloud.Database.LookupTables;

namespace PropertyOwnerTest
{
    class DataTest
    {
        private PropertyOwnerContext db;

        public PropertyOwnerContext Db { get => db; }

        public DataTest()
        {
            this.db = new PropertyOwnerContextFactory().CreateDbContext();
        }

        public void CleanDatabase()
        {
            db.RemoveRange(db.Mortgage);
            db.RemoveRange(db.PropertyOwner);
            db.RemoveRange(db.PropertyDetails);
            db.RemoveRange(db.Owner);
            db.RemoveRange(db.AddressDetails);
            db.RemoveRange(db.RoofType);
            db.RemoveRange(db.DeedType);
            db.RemoveRange(db.MortgageLoanType);
            db.RemoveRange(db.MortgageDeedType);
            db.SaveChanges();
        }

        public RoofType CreateRoofType()
        {
            return new RoofType
            {
                RoofTypeCode = "10",
                RoofTypeDescription = "Spanish Tile"
            };
        }

        public AddressDetails CreateAddress()
        {
            return new AddressDetails
            {
                Address = "Los Angeles, California, US",
                City = "Los Angeles",
                Latitude = -45.667,
                Longitude = -40.889,
                PhoneNumber = 959510911,
                State = "California",
                StreetName = "strip",
                Zip = 05429130
            };
        }

        public PropertyDetails CreateProperty(double salePrice = 754000)
        {
            return new PropertyDetails
            {
                SalePrice = salePrice
            };
        }

        public Owner CreateOwner(string ownerName)
        {
            return new Owner
            {
                OwnerName = ownerName
            };
        }

        public DeedType CreateDeedType()
        {
            return new DeedType
            {
                DeedTypeCode = "30",
                DeedTypeDescription = "Warranty"
            };
        }

        public MortgageLoanType CreateMortgageLoanType()
        {
            return new MortgageLoanType
            {
                MortgageLoanTypeCode = "10",
                MortgageLoanTypeDescription = "repayment mortgages"
            };
        }

        public MortgageDeedType CreateMortgageDeedType()
        {
            return new MortgageDeedType
            {
                MortgageDeedTypeCode = "10",
                MortgageDeedTypeDescription = "Simple Mortgage"
            };
        }

        public Mortgage CreateMortgage()
        {
            return new Mortgage();
        }

        public Property_Owner CreatePropertyOwner()
        {
            return new Property_Owner();
        }
    }
}
