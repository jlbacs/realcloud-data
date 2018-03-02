using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using RealCloud.Database;
using System.Linq;

namespace PropertyOwnerTest
{
    [TestClass]
    public class Property_OwnerTest
    {
        private DataTest dataTest;
        private PropertyOwnerContext db;

        [TestInitialize]
        public void Setup()
        {
            this.dataTest = new DataTest();
            this.db = dataTest.Db;
        }

        [TestMethod]
        public void TestPropertyOwnerRelationship()
        {
            var propertyOwner = dataTest.CreatePropertyOwner();
            propertyOwner.Property = dataTest.CreateProperty();
            propertyOwner.Owner = dataTest.CreateOwner("Joel");
            db.Add(propertyOwner);
            db.SaveChanges();

            Assert.AreSame(propertyOwner.Property, propertyOwner.Owner.PropertyOwner.First().Property);
            Assert.AreSame(propertyOwner.Owner, propertyOwner.Property.PropertyOwner.First().Owner);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestInsertPKNullConstraint()
        {
            var propertyOwner = dataTest.CreatePropertyOwner();
            db.Add(propertyOwner);
            db.SaveChanges();
        }

        [TestCleanup]
        public void TearDown()
        {
            db.Dispose();
        }
    }
}
