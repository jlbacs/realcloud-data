﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RealCloud.Database;
using System;

namespace RealCloud.Database.Migrations
{
    [DbContext(typeof(PropertyOwnerContext))]
    [Migration("20180225191746_RenameMortgageLoanType")]
    partial class RenameMortgageLoanType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PropertyOwnerLib.AddressDetails", b =>
                {
                    b.Property<int>("AddressKey")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<double?>("Latitude");

                    b.Property<double?>("Longitude");

                    b.Property<int?>("PhoneNumber");

                    b.Property<string>("State");

                    b.Property<string>("StreetName");

                    b.Property<int?>("Zip");

                    b.HasKey("AddressKey");

                    b.ToTable("AddressDetails");
                });

            modelBuilder.Entity("PropertyOwnerLib.DeedType", b =>
                {
                    b.Property<string>("DeedTypeCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeedTypeDescription");

                    b.HasKey("DeedTypeCode");

                    b.ToTable("DeedType");
                });

            modelBuilder.Entity("PropertyOwnerLib.MortgageLoanType", b =>
                {
                    b.Property<string>("MortgageLoanTypeCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MortgageLoanTypeDescription");

                    b.HasKey("MortgageLoanTypeCode");

                    b.ToTable("MortgageLoanType");
                });

            modelBuilder.Entity("PropertyOwnerLib.Owner", b =>
                {
                    b.Property<string>("OwnerMatchCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbsenteeOwnerCode")
                        .HasMaxLength(1);

                    b.Property<int?>("AddressKey");

                    b.Property<bool?>("CorporateOwner");

                    b.Property<string>("OwnerCarrierRoute");

                    b.Property<bool?>("OwnerMailOptOut");

                    b.Property<string>("OwnerName");

                    b.Property<string>("OwnerName2");

                    b.Property<bool?>("OwnerPhoneOptOut");

                    b.Property<string>("OwnerSuite");

                    b.Property<string>("OwnerUnparsedName1");

                    b.Property<string>("OwnerUnparsedName2");

                    b.HasKey("OwnerMatchCode");

                    b.HasIndex("AddressKey");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("PropertyOwnerLib.Property_Owner", b =>
                {
                    b.Property<string>("OwnerMatchCode");

                    b.Property<int>("PropertyIndicatorCode");

                    b.HasKey("OwnerMatchCode", "PropertyIndicatorCode");

                    b.HasIndex("PropertyIndicatorCode");

                    b.ToTable("PropertyOwner");
                });

            modelBuilder.Entity("PropertyOwnerLib.PropertyDetails", b =>
                {
                    b.Property<int>("PropertyIndicatorCode")
                        .ValueGeneratedOnAdd();

                    b.Property<double?>("Acreage");

                    b.Property<int?>("AddressKey");

                    b.Property<double?>("AdjustedGross");

                    b.Property<string>("AirConditioningCode");

                    b.Property<int?>("ApnSequenceNo");

                    b.Property<double?>("AppraisedImprovementValue");

                    b.Property<double?>("AppraisedLandValue");

                    b.Property<double?>("AppraisedTotalValue");

                    b.Property<double?>("AssessedImprovementValue");

                    b.Property<double?>("AssessedLandValue");

                    b.Property<double?>("AssessedTotalValue");

                    b.Property<int?>("Basement");

                    b.Property<string>("BasementCode");

                    b.Property<int?>("BathFixtures");

                    b.Property<int?>("Bedrooms");

                    b.Property<int?>("BuildingArea");

                    b.Property<string>("BuildingAreaCode")
                        .HasMaxLength(1);

                    b.Property<string>("BuildingCode");

                    b.Property<string>("BuildingStyleCode");

                    b.Property<double?>("CalculatedImprovementValue");

                    b.Property<string>("CalculatedImprovementValueCode")
                        .HasMaxLength(1);

                    b.Property<double?>("CalculatedLandValue");

                    b.Property<string>("CalculatedLandValueCode")
                        .HasMaxLength(1);

                    b.Property<double?>("CalculatedTotalValue");

                    b.Property<string>("CalculatedTotalValueCode")
                        .HasMaxLength(1);

                    b.Property<int?>("CensusTract");

                    b.Property<string>("ConditionCode");

                    b.Property<string>("ConstructionCode");

                    b.Property<int?>("CountyLandUse1");

                    b.Property<int?>("CountyLandUse2");

                    b.Property<string>("DeedCategoryCode");

                    b.Property<string>("DeedTypeCode");

                    b.Property<int?>("DepthFootage");

                    b.Property<int?>("DocumentYear");

                    b.Property<int?>("EffectiveYearBuilt");

                    b.Property<string>("ElectricityCode");

                    b.Property<string>("ExteriorWallCode");

                    b.Property<int?>("FipsCode");

                    b.Property<string>("FipsSubCode");

                    b.Property<bool?>("Fireplace");

                    b.Property<string>("FireplaceCode");

                    b.Property<int?>("Fireplaces");

                    b.Property<string>("FlooringCode")
                        .HasMaxLength(1);

                    b.Property<string>("FormattedApn");

                    b.Property<string>("FoundationCode");

                    b.Property<int?>("FrontFootage");

                    b.Property<string>("FuelCode");

                    b.Property<int?>("FullBaths");

                    b.Property<string>("GarageCode");

                    b.Property<int?>("GarageOrParking");

                    b.Property<int?>("Gross");

                    b.Property<int?>("GroundFloor");

                    b.Property<int?>("HalfBaths");

                    b.Property<string>("HeatingCode");

                    b.Property<bool?>("HomesteadExempt");

                    b.Property<string>("ImprovementCode");

                    b.Property<int?>("LandUseCode");

                    b.Property<int?>("LenderCode");

                    b.Property<string>("LenderName");

                    b.Property<int?>("LivingSpace");

                    b.Property<string>("LocationInfluenceCode");

                    b.Property<double?>("MarketImprovementValue");

                    b.Property<double?>("MarketLandValue");

                    b.Property<double?>("MarketTotalValue");

                    b.Property<bool?>("MobileHome");

                    b.Property<double?>("MortgageAmount");

                    b.Property<double?>("MortgageAssumptionAmount");

                    b.Property<DateTime?>("MortgageDate");

                    b.Property<string>("MortgageDeedTypeCode");

                    b.Property<DateTime?>("MortgageDueDate");

                    b.Property<string>("MortgageLoanTypeCode");

                    b.Property<int?>("MortgageTerm");

                    b.Property<string>("MortgageTermCode")
                        .HasMaxLength(1);

                    b.Property<string>("MultiApnCode")
                        .HasMaxLength(1);

                    b.Property<int?>("MultiApnCount");

                    b.Property<string>("MunicipalityName");

                    b.Property<int?>("NumberOfBuildings");

                    b.Property<int?>("OneQuarterBaths");

                    b.Property<int?>("OriginalApn");

                    b.Property<string>("ParkingCode");

                    b.Property<int?>("ParkingSpaces");

                    b.Property<int?>("ParsedRange");

                    b.Property<bool?>("Pool");

                    b.Property<string>("PoolCode");

                    b.Property<string>("PostDirectional");

                    b.Property<string>("Predirectional");

                    b.Property<int?>("PriorDeedCategoryCode");

                    b.Property<int?>("PriorDocumentYear");

                    b.Property<int?>("PriorMortgageAmount");

                    b.Property<string>("PriorMultiApnCode")
                        .HasMaxLength(1);

                    b.Property<string>("PriorMultiApnCount");

                    b.Property<DateTime?>("PriorRecordingDate");

                    b.Property<string>("PriorSaleCode")
                        .HasMaxLength(1);

                    b.Property<DateTime?>("PriorSaleDate");

                    b.Property<double?>("PriorSalePrice");

                    b.Property<int?>("PriorTransactionId");

                    b.Property<string>("PropertyResults");

                    b.Property<string>("QualityCode");

                    b.Property<string>("QuarterSection");

                    b.Property<string>("Range");

                    b.Property<DateTime?>("RecordingDate");

                    b.Property<string>("ResidentalModel");

                    b.Property<int?>("RoofCoverCode");

                    b.Property<string>("RoofFramingCode");

                    b.Property<string>("RoofTypeCode");

                    b.Property<string>("SaleCode")
                        .HasMaxLength(1);

                    b.Property<DateTime?>("SaleDate");

                    b.Property<double?>("SalePrice");

                    b.Property<double?>("SecondMortgageAmount");

                    b.Property<string>("SecondMortgageDeedTypeCode");

                    b.Property<string>("SecondMortgageLoanTypeCode");

                    b.Property<int?>("Section");

                    b.Property<string>("SellerName");

                    b.Property<string>("SewerCode");

                    b.Property<int?>("SquareFootage");

                    b.Property<int?>("Stories");

                    b.Property<string>("StoriesCode");

                    b.Property<string>("Suffix");

                    b.Property<string>("SuiteName");

                    b.Property<string>("SuiteRange");

                    b.Property<double?>("TaxAmount");

                    b.Property<int?>("TaxYear");

                    b.Property<int?>("ThreeQuarterBaths");

                    b.Property<double?>("TotalBaths");

                    b.Property<int?>("TotalBathsCalculated");

                    b.Property<int?>("TotalRooms");

                    b.Property<string>("Township");

                    b.Property<int?>("TransactionId");

                    b.Property<int?>("TransactionId1");

                    b.Property<int?>("UnformattedApn");

                    b.Property<int?>("Units");

                    b.Property<int?>("UniversalBuilding");

                    b.Property<string>("ViewCode");

                    b.Property<string>("WaterCode");

                    b.Property<int?>("YearBuilt");

                    b.Property<string>("Zoning");

                    b.HasKey("PropertyIndicatorCode");

                    b.HasIndex("AddressKey")
                        .IsUnique()
                        .HasFilter("[AddressKey] IS NOT NULL");

                    b.HasIndex("DeedTypeCode");

                    b.HasIndex("MortgageLoanTypeCode");

                    b.HasIndex("RoofTypeCode");

                    b.ToTable("PropertyDetails");
                });

            modelBuilder.Entity("PropertyOwnerLib.RoofType", b =>
                {
                    b.Property<string>("RoofTypeCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoofTypeDescription");

                    b.HasKey("RoofTypeCode");

                    b.ToTable("RoofType");
                });

            modelBuilder.Entity("PropertyOwnerLib.Owner", b =>
                {
                    b.HasOne("PropertyOwnerLib.AddressDetails", "OwnerCurrentAddress")
                        .WithMany("Owner")
                        .HasForeignKey("AddressKey")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PropertyOwnerLib.Property_Owner", b =>
                {
                    b.HasOne("PropertyOwnerLib.Owner", "Owner")
                        .WithMany("PropertyOwner")
                        .HasForeignKey("OwnerMatchCode")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PropertyOwnerLib.PropertyDetails", "Property")
                        .WithMany("PropertyOwner")
                        .HasForeignKey("PropertyIndicatorCode")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PropertyOwnerLib.PropertyDetails", b =>
                {
                    b.HasOne("PropertyOwnerLib.AddressDetails", "PropertyAddress")
                        .WithOne("Property")
                        .HasForeignKey("PropertyOwnerLib.PropertyDetails", "AddressKey")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PropertyOwnerLib.DeedType", "DeedType")
                        .WithMany("Properties")
                        .HasForeignKey("DeedTypeCode")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PropertyOwnerLib.MortgageLoanType", "MortgageLoanType")
                        .WithMany("Properties")
                        .HasForeignKey("MortgageLoanTypeCode")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PropertyOwnerLib.RoofType", "RoofType")
                        .WithMany("Properties")
                        .HasForeignKey("RoofTypeCode")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
