using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RealCloud.Data
{
    public class PropertyOwnerContextFactory : IDesignTimeDbContextFactory<PropertyOwnerContext>
    {
        private const string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DB_PropertyOwner;Integrated Security=True";

        public PropertyOwnerContext CreateDbContext(string[] args = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PropertyOwnerContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new PropertyOwnerContext(optionsBuilder.Options);
        }
    }
}
