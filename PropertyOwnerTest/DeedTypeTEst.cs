using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using RealCloud.Data;

namespace PropertyOwnerTest
{
    [TestClass]
    public class DeedTypeTest
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
        public void TestDeedTypeInsert()
        {
            var deedType = dataTest.CreateDeedType();
            db.Add(deedType);
            db.SaveChanges();

            Assert.IsTrue(db.Entry(deedType).State == Microsoft.EntityFrameworkCore.EntityState.Unchanged);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestOnDeleteRestrict()
        {
            var property = dataTest.CreateProperty();
            var deedType = dataTest.CreateDeedType();
            property.DeedType = deedType;
            db.Add(property);
            db.SaveChanges();

            db.Remove(deedType);
            db.SaveChanges();
        }

        [TestMethod]
        public void TestPopertiesNavigation()
        {
            var property1 = dataTest.CreateProperty(80888);
            var property2 = dataTest.CreateProperty(91333);
            var deedType = dataTest.CreateDeedType();
            property1.DeedType = deedType;
            property2.DeedType = deedType;
            db.AddRange(property1, property2);
            db.SaveChanges();
            Assert.AreEqual(deedType.Properties.Count, 2);
        }

        [TestCleanup]
        public void TearDown()
        {
            db.Dispose();
        }
    }
}
