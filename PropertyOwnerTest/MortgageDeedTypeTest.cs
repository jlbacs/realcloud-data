using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using RealCloud.Data;

namespace PropertyOwnerTest
{
    [TestClass]
    public class MortgageDeedTypeTest
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
            var mortgageDeedType = dataTest.CreateMortgageDeedType();
            db.Add(mortgageDeedType);
            db.SaveChanges();

            Assert.IsTrue(db.Entry(mortgageDeedType).State == Microsoft.EntityFrameworkCore.EntityState.Unchanged);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestOnDeleteRestrict()
        {
            var mortgage = dataTest.CreateMortgage();
            mortgage.MortgageDeedType = dataTest.CreateMortgageDeedType();
            db.Add(mortgage);
            db.SaveChanges();

            db.Remove(mortgage.MortgageDeedType);
            db.SaveChanges();
        }

        [TestMethod]
        public void TestPropertiesNavigation()
        {
            var mortgage1 = dataTest.CreateMortgage();
            var mortgage2 = dataTest.CreateMortgage();
            var mortgageDeedType = dataTest.CreateMortgageDeedType();
            mortgage1.MortgageDeedType = mortgageDeedType;
            mortgage2.MortgageDeedType = mortgageDeedType;
            db.AddRange(mortgage1, mortgage2);
            db.SaveChanges();

            Assert.AreEqual(mortgageDeedType.Mortgages.Count, 2);
        }

        [TestCleanup]
        public void TearDown()
        {
            db.Dispose();
        }
    }
}
