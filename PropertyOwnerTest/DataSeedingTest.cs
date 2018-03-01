using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using RealCloud.Data;
using System.Linq;

namespace PropertyOwnerTest
{
    [TestClass]
    public class DataSeedingTest
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
        public void TestSeedData()
        {
            var dataSeeding = new DataSeeding(db);
            dataSeeding.SeedData();

            Assert.AreEqual(db.MortgageLoanType.Count(), 13);
            Assert.AreEqual(db.DeedType.Count(), 5);
            Assert.AreEqual(db.RoofType.Count(), 3);
            Assert.AreEqual(db.MortgageDeedType.Count(), 6);
        }

        [TestCleanup]
        public void TearDown()
        {
            db.Dispose();
        }
    }
}
