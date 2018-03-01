using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using RealCloud.Data;
using System.Linq;

namespace PropertyOwnerTest
{
    [TestClass]
    public class PropertyDetailsTest
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
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestPropertyOnDeleteRestrictForMortgage()
        {
            var mortgage = dataTest.CreateMortgage();
            mortgage.PropertyDetails = dataTest.CreateProperty();
            db.Add(mortgage);
            db.SaveChanges();

            db.Remove(mortgage.PropertyDetails);
            db.SaveChanges();
        }

        [TestCleanup]
        public void TearDown()
        {
            db.Dispose();
        }
    }
}
