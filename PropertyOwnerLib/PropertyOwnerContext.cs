using System;
using Microsoft.EntityFrameworkCore;

namespace RealCloud.Data
{
    public class PropertyOwnerContext : DbContext
    {
        public PropertyOwnerContext() { }

        public PropertyOwnerContext(DbContextOptions<PropertyOwnerContext> options) : base(options) { }

        public virtual DbSet<AddressDetails> AddressDetails { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }
        public virtual DbSet<PropertyDetails> PropertyDetails { get; set; }
        public virtual DbSet<Property_Owner> PropertyOwner { get; set; }
        public virtual DbSet<RoofType> RoofType { get; set; }
        public virtual DbSet<DeedType> DeedType { get; set; }
        public virtual DbSet<MortgageLoanType> MortgageLoanType { get; set; }
        public virtual DbSet<MortgageDeedType> MortgageDeedType { get; set; }
        public virtual DbSet<Mortgage> Mortgage { get; set; }

        private const int maxLengthForChar = 1;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureAddressDetails(modelBuilder);
            ConfigureOwner(modelBuilder);
            ConfigurePropertyDetails(modelBuilder);
            ConfigurePropertyOwner(modelBuilder);
            ConfigureRoofType(modelBuilder);
            ConfigureDeedType(modelBuilder);
            ConfigureMortgageLoanType(modelBuilder);
            ConfigureMortgageDeedType(modelBuilder);
            ConfigureMortgage(modelBuilder);
        }

        private void ConfigureMortgage(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mortgage>(e =>
            {
                e.HasKey(m => m.MortgageId);
                e.HasOne(m => m.PropertyDetails).WithMany(p => p.Mortgages).HasForeignKey(m => m.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);
                e.Property(p => p.MortgageTermCode).HasMaxLength(maxLengthForChar);
            });
        }

        private void ConfigureMortgageDeedType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MortgageDeedType>(e =>
            {
                e.HasKey(m => m.MortgageDeedTypeCode);
                e.HasMany(m => m.Mortgages).WithOne(p => p.MortgageDeedType)
                .OnDelete(DeleteBehavior.Restrict).HasForeignKey(p => p.MortgageDeedTypeCode);
                e.HasMany(m => m.MortgagesSecond).WithOne(p => p.SecondMortgageDeedType)
                .OnDelete(DeleteBehavior.Restrict).HasForeignKey(p => p.SecondMortgageDeedTypeCode);
            });
        }

        private void ConfigureMortgageLoanType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MortgageLoanType>(e =>
            {
                e.HasKey(m => m.MortgageLoanTypeCode);
                e.HasMany(m => m.Mortgages).WithOne(p => p.MortgageLoanType)
                .OnDelete(DeleteBehavior.Restrict).HasForeignKey(p => p.MortgageLoanTypeCode);
                e.HasMany(m => m.MortgagesSecond).WithOne(p => p.SecondMortgageLoanType)
                .OnDelete(DeleteBehavior.Restrict).HasForeignKey(p => p.SecondMortgageLoanTypeCode);
            });
        }

        private void ConfigureDeedType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeedType>(e =>
            {
                e.HasKey(d => d.DeedTypeCode);
                e.HasMany(d => d.Properties).WithOne(p => p.DeedType).OnDelete(DeleteBehavior.Restrict);
            });
        }

        private void ConfigureRoofType(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoofType>(e =>
            {
                e.HasKey(r => r.RoofTypeCode);
                e.HasMany(r => r.Properties).WithOne(p => p.RoofType).OnDelete(DeleteBehavior.Restrict);
            });
        }

        private void ConfigureAddressDetails(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressDetails>(e =>
            {
                e.HasKey(a => a.AddressDetailsId);
            });
        }

        private void ConfigureOwner(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>(e =>
            {
                e.HasKey(o => o.OwnerId);
                e.Property(o => o.AbsenteeOwnerCode).HasMaxLength(maxLengthForChar);
                e.HasOne(o => o.OwnerCurrentAddress).WithMany(a => a.Owner).OnDelete(DeleteBehavior.Restrict);
            });
        }

        private void ConfigurePropertyDetails(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PropertyDetails>(e =>
            {
                e.HasKey(p => p.PropertyId);
                e.HasOne(p => p.PropertyAddress).WithOne(a => a.Property).OnDelete(DeleteBehavior.Restrict);
                e.Property(p => p.SaleCode).HasMaxLength(maxLengthForChar);
                e.Property(p => p.PriorMultiApnCode).HasMaxLength(maxLengthForChar);
                e.Property(p => p.MultiApnCode).HasMaxLength(maxLengthForChar);
                e.Property(p => p.CalculatedLandValueCode).HasMaxLength(maxLengthForChar);
                e.Property(p => p.FlooringCode).HasMaxLength(maxLengthForChar);
                e.Property(p => p.BuildingAreaCode).HasMaxLength(maxLengthForChar);
                e.Property(p => p.PriorSaleCode).HasMaxLength(maxLengthForChar);
                e.Property(p => p.CalculatedImprovementValueCode).HasMaxLength(maxLengthForChar);
                e.Property(p => p.CalculatedTotalValueCode).HasMaxLength(maxLengthForChar);                
            });
        }

        private void ConfigurePropertyOwner(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property_Owner>(e =>
            {
                e.HasKey(po => new { po.OwnerId, po.PropertyId });
                e.HasOne(po => po.Owner).WithMany(o => o.PropertyOwner).OnDelete(DeleteBehavior.Restrict);
                e.HasOne(po => po.Property).WithMany(p => p.PropertyOwner).OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
