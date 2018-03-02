using Microsoft.VisualStudio.TestTools.UnitTesting;
using RealCloud.Database;
using System;

namespace PropertyOwnerTest
{
    [TestClass]
    public class RoofTypeTest
    {
        private DataTest dataTest;
        private PropertyOwnerContext db;

        [TestInitialize]
        public void Setup()
        {
            this.dataTest = new DataTest();
            this.db = dataTest.Db;
            // clean database
            dataTest.CleanDatabase();
        }

        [TestMethod]
        public void TestRoofTypeInsert()
        {
            // arrange
            var expectedRoofType = dataTest.CreateRoofType();
            db.Add(expectedRoofType);
            // act
            db.SaveChanges();
            // assert
            Assert.IsTrue(db.Entry(expectedRoofType).State == Microsoft.EntityFrameworkCore.EntityState.Unchanged);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestOnDeleteRestrict()
        {
            var propertyDetails = dataTest.CreateProperty();
            propertyDetails.RoofType = dataTest.CreateRoofType();
            db.Add(propertyDetails);
            db.SaveChanges();
            // delete roof type
            db.Remove(propertyDetails.RoofType);
            db.SaveChanges();
        }

        [TestMethod]
        public void TestPropertiesNavigation()
        {
            var property1 = dataTest.CreateProperty(498000);
            var property2 = dataTest.CreateProperty(555666);
            var roofType = dataTest.CreateRoofType();
            property1.RoofType = roofType;
            property2.RoofType = roofType;
            db.AddRange(property1, property2);
            db.SaveChanges();

            Assert.AreEqual(roofType.Properties.Count, 2);
        }

        [TestCleanup]
        public void TearDown()
        {
            db.Dispose();
        }
    }
}
