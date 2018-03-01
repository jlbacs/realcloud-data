﻿using System;
using System.Collections.Generic;

namespace RealCloud.Data
{
    public class PropertyDetails
    {
        public int PropertyId { get; set; }
        public int? PropertyIndicatorCode { get; set; }
        public string SaleCode { get; set; }
        public string PriorMultiApnCode { get; set; }
        public int? LandUseCode { get; set; }
        public string HeatingCode { get; set; }
        public int? BuildingArea { get; set; }
        public string RoofTypeCode { get; set; }
        public double? TaxAmount { get; set; }
        public int? RoofCoverCode { get; set; }
        public string ResidentalModel { get; set; }
        public string FireplaceCode { get; set; }
        public string Zoning { get; set; }
        public int? DepthFootage { get; set; }
        public bool? Fireplace { get; set; }
        public int? LivingSpace { get; set; }
        public int? HalfBaths { get; set; }
        public int? GroundFloor { get; set; }
        public int? EffectiveYearBuilt { get; set; }
        public int? ParsedRange { get; set; }
        public double? AppraisedLandValue { get; set; }        
        public double? CalculatedLandValue { get; set; }
        public string ViewCode { get; set; }
        public int? PriorTransactionId { get; set; }
        public int? Section { get; set; }
        public string MunicipalityName { get; set; }
        public string GarageCode { get; set; }
        public bool? MobileHome { get; set; }
        public string PriorMultiApnCount { get; set; }
        public int? MultiApnCount { get; set; }
        public int? ParkingSpaces { get; set; }
        public bool? Pool { get; set; }     
        public int? CensusTract { get; set; }
        public int? BathFixtures { get; set; }
        public int? Basement { get; set; }
        public DateTime? SaleDate { get; set; }
        public string ConstructionCode { get; set; }
        public string MultiApnCode { get; set; }
        public string CalculatedLandValueCode { get; set; }
        public DateTime? PriorSaleDate { get; set; }
        public int? FrontFootage { get; set; }
        public int? Bedrooms { get; set; }
        public string ElectricityCode { get; set; }
        public double? MarketLandValue { get; set; }
        public DateTime? PriorRecordingDate { get; set; }
        public double? Acreage { get; set; }
        public int? Units { get; set; }
        public double? AppraisedTotalValue { get; set; }
        public int? TotalBathsCalculated { get; set; }
        public double? AssessedImprovementValue { get; set; }
        public int? TotalRooms { get; set; }
        public int? Fireplaces { get; set; }
        public string FlooringCode { get; set; }
        public string FipsSubCode { get; set; }
        public string DeedTypeCode { get; set; }
        public string LenderName { get; set; }
        public int? PriorDeedCategoryCode { get; set; }
        public string Township { get; set; }
        public double? CalculatedTotalValue { get; set; }
        public double? TotalBaths { get; set; }
        public string PoolCode { get; set; }
        public string BuildingAreaCode { get; set; }
        public string SewerCode { get; set; }
        public double? AssessedLandValue { get; set; }
        public string ExteriorWallCode { get; set; }
        public double? CalculatedImprovementValue { get; set; }
        public DateTime? RecordingDate { get; set; }
        public string ParkingCode { get; set; }
        public int? SquareFootage { get; set; }
        public string DeedCategoryCode { get; set; }
        public string QualityCode { get; set; }
        public string Suffix { get; set; }
        public double? MarketImprovementValue { get; set; }
        public string PriorSaleCode { get; set; }
        public string BuildingCode { get; set; }
        public int? PriorDocumentYear { get; set; }
        public double? AssessedTotalValue { get; set; }
        public string PostDirectional { get; set; }
        public double? AdjustedGross { get; set; }
        public string CalculatedImprovementValueCode { get; set; }
        public string SellerName { get; set; }
        public string ConditionCode { get; set; }
        public int? CountyLandUse1 { get; set; }
        public int? NumberOfBuildings { get; set; }
        public int? CountyLandUse2 { get; set; }
        public string FuelCode { get; set; }
        public int? TransactionId { get; set; }
        public int? ThreeQuarterBaths { get; set; }
        public string Predirectional { get; set; }
        public double? SalePrice { get; set; }
        public int? UniversalBuilding { get; set; }
        public string BuildingStyleCode { get; set; }
        public int? OriginalApn { get; set; }
        public int? GarageOrParking { get; set; }        
        public string StoriesCode { get; set; }
        public int? TransactionId1 { get; set; }
        public int? FipsCode { get; set; }
        public double? MarketTotalValue { get; set; }
        public int? OneQuarterBaths { get; set; }
        public string WaterCode { get; set; }
        public int? LenderCode { get; set; }
        public int? UnformattedApn { get; set; }        
        public int? FullBaths { get; set; }
        public string AirConditioningCode { get; set; }
        public string FormattedApn { get; set; }
        public string FoundationCode { get; set; }
        public int? YearBuilt { get; set; }
        public double? PriorSalePrice { get; set; }
        public string BasementCode { get; set; }
        public string Range { get; set; }        
        public int? DocumentYear { get; set; }
        public string ImprovementCode { get; set; }
        public int? Stories { get; set; }
        public string QuarterSection { get; set; }        
        public string RoofFramingCode { get; set; }
        public string LocationInfluenceCode { get; set; }
        public int? Gross { get; set; }
        public double? AppraisedImprovementValue { get; set; }
        public int? ApnSequenceNo { get; set; }
        public bool? HomesteadExempt { get; set; }
        public string CalculatedTotalValueCode { get; set; }
        public int? TaxYear { get; set; }
        public string SuiteName { get; set; }
        public string SuiteRange { get; set; }
        public string PropertyResults { get; set; }
        public int? AddressDetailsId { get; set; }
        
        public virtual AddressDetails PropertyAddress { get; set; }
        public virtual RoofType RoofType { get; set; }
        public virtual DeedType DeedType { get; set; }
        public virtual ICollection<Property_Owner> PropertyOwner { get; set; }
        public virtual ICollection<Mortgage> Mortgages { get; set; }
    }
}
