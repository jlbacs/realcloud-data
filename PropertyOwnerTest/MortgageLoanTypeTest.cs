using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using RealCloud.Database;

namespace PropertyOwnerTest
{
    [TestClass]
    public class MortgageLoanTypeTest
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
        public void TestInsert()
        {
            var mortgageLoanType = dataTest.CreateMortgageLoanType();
            db.Add(mortgageLoanType);
            db.SaveChanges();
            Assert.IsTrue(db.Entry(mortgageLoanType).State == Microsoft.EntityFrameworkCore.EntityState.Unchanged);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestOnDeleteRestrict()
        {
            var mortgage = dataTest.CreateMortgage();
            mortgage.MortgageLoanType = dataTest.CreateMortgageLoanType();
            db.Add(mortgage);
            db.SaveChanges();

            db.Remove(mortgage.MortgageLoanType);
            db.SaveChanges();
        }

        [TestMethod]
        public void TestPropertiesNavigation()
        {
            var mortgage1 = dataTest.CreateMortgage();
            var mortgage2 = dataTest.CreateMortgage();
            var mortgageLoanType = dataTest.CreateMortgageLoanType();
            mortgage1.MortgageLoanType = mortgageLoanType;
            mortgage2.MortgageLoanType = mortgageLoanType;
            db.AddRange(mortgage1, mortgage2);
            db.SaveChanges();

            Assert.AreEqual(mortgageLoanType.Mortgages.Count, 2);
        }

        [TestCleanup]
        public void TearDown()
        {
            db.Dispose();
        }
    }
}
