using RealCloud.Database;
using System;

namespace PropertyOwner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connecting to database...");
            using (var db = new PropertyOwnerContextFactory().CreateDbContext(null))
            {
                Console.WriteLine("Cleaning data from Property, Owner and Address...");
                db.PropertyOwner.RemoveRange(db.PropertyOwner);
                db.PropertyDetails.RemoveRange(db.PropertyDetails);
                db.Owner.RemoveRange(db.Owner);
                db.AddressDetails.RemoveRange(db.AddressDetails);
                db.SaveChanges();

                Console.WriteLine("Adding data to Property, Owner and Address...");
                var propertyAddress = new AddressDetails
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
                var newProperty1 = new PropertyDetails
                {
                    SalePrice = 150000,
                    PropertyAddress = propertyAddress
                };
                db.AddRange(newProperty1);
                db.SaveChanges();

                Console.WriteLine("Completed.");
                Console.WriteLine("Showing data from database:");
                foreach (var property in db.PropertyDetails)
                {                    
                    Console.WriteLine($"Property Address: {property.PropertyAddress.Address}");
                }
            }
            Console.ReadKey();
        }
    }
}
