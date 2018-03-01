using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RealCloud.Data;
using Microsoft.EntityFrameworkCore;

namespace PropertyOwnerTest
{
    [TestClass]
    public class AddressDetailsTest
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
        public void TestOnDeleteRestrict()
        {
            var propertyDetails = dataTest.CreateProperty();
            propertyDetails.PropertyAddress = dataTest.CreateAddress();
            db.Add(propertyDetails);
            db.SaveChanges();
            // delete address
            db.Remove(propertyDetails.PropertyAddress);
            db.SaveChanges();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestOneAddressForManyPropertiesViolation()
        {
            var property1 = dataTest.CreateProperty();
            var property2 = dataTest.CreateProperty();
            var address = dataTest.CreateAddress();
            property1.PropertyAddress = address;
            property2.PropertyAddress = address;

            db.AddRange(property1, property2);
            db.SaveChanges();
        }

        [TestMethod]
        public void TestOneAddressForManyOwners()
        {
            var address = dataTest.CreateAddress();
            var owner1 = dataTest.CreateOwner("Joaquim");
            var owner2 = dataTest.CreateOwner("Jessica");
            owner1.OwnerCurrentAddress = address;
            owner2.OwnerCurrentAddress = address;
            db.AddRange(owner1, owner2);
            db.SaveChanges();

            Assert.IsTrue(db.Entry(owner1).State == EntityState.Unchanged
                && db.Entry(owner2).State == EntityState.Unchanged);
            Assert.AreSame(owner1.OwnerCurrentAddress, owner2.OwnerCurrentAddress);
        }

        [TestMethod]
        public void TestOwnerNavigation()
        {
            var address = dataTest.CreateAddress();
            var owner1 = dataTest.CreateOwner("Joaquim");
            var owner2 = dataTest.CreateOwner("Jessica");
            owner1.OwnerCurrentAddress = address;
            owner2.OwnerCurrentAddress = address;
            db.AddRange(owner1, owner2);
            db.SaveChanges();

            Assert.AreEqual(address.Owner.Count, 2);
        }

        [TestCleanup]
        public void TearDown()
        {
            db.Dispose();
        }
    }
}
