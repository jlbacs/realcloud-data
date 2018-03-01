using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealCloud.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PropertyOwnerTest
{
    [TestClass]
    public class MortgageTest
    {
        private DataTest dataTest;
        private PropertyOwnerContext db;

        [TestInitialize]
        public void Setup()
        {
            this.dataTest = new DataTest();
            this.db = dataTest.Db;
            dataTest.CleanDatabase();
        }

        [TestMethod]
        public void TestSecondMortgageLoanTypeRelationship()
        {
            var mortgage = dataTest.CreateMortgage();
            var mortgageLoanType = dataTest.CreateMortgageLoanType();
            mortgage.SecondMortgageLoanType = mortgageLoanType;
            db.Add(mortgage);
            db.SaveChanges();

            Assert.AreSame(mortgageLoanType.MortgagesSecond.First(), mortgage);
            Assert.IsNull(mortgage.MortgageLoanType);
            Assert.IsNull(mortgageLoanType.Mortgages);
        }

        [TestMethod]
        public void TestSecondMortgageDeedTypeRelationship()
        {
            var mortgage = dataTest.CreateMortgage();
            var mortgageDeedType = dataTest.CreateMortgageDeedType();
            mortgage.SecondMortgageDeedType = mortgageDeedType;
            db.Add(mortgage);
            db.SaveChanges();

            Assert.AreSame(mortgageDeedType.MortgagesSecond.First(), mortgage);
            Assert.IsNull(mortgage.MortgageDeedType);
        }

        [TestMethod]
        public void TestPropertyDetailsRelationship()
        {
            var mortgage = dataTest.CreateMortgage();
            mortgage.PropertyDetails = dataTest.CreateProperty();
            db.Add(mortgage);
            db.SaveChanges();

            Assert.AreSame(mortgage, mortgage.PropertyDetails.Mortgages.First());
        }

        [TestCleanup]
        public void TearDown()
        {
            db.Dispose();
        }
    }
}
