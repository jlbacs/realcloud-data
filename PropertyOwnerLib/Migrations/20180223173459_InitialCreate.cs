using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressDetails",
                columns: table => new
                {
                    AddressKey = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    State = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressDetails", x => x.AddressKey);
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    OwnerMatchCode = table.Column<string>(nullable: false),
                    AbsenteeOwnerCode = table.Column<string>(maxLength: 1, nullable: true),
                    AddressKey = table.Column<int>(nullable: false),
                    CorporateOwner = table.Column<bool>(nullable: false),
                    OwnerCarrierRoute = table.Column<string>(nullable: true),
                    OwnerMailOptOut = table.Column<bool>(nullable: false),
                    OwnerName = table.Column<string>(nullable: true),
                    OwnerName2 = table.Column<string>(nullable: true),
                    OwnerPhoneOptOut = table.Column<bool>(nullable: false),
                    OwnerSuite = table.Column<string>(nullable: true),
                    OwnerUnparsedName1 = table.Column<string>(nullable: true),
                    OwnerUnparsedName2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.OwnerMatchCode);
                    table.ForeignKey(
                        name: "FK_Owner_AddressDetails_AddressKey",
                        column: x => x.AddressKey,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressKey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyDetails",
                columns: table => new
                {
                    PropertyIndicatorCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Acreage = table.Column<double>(nullable: false),
                    AddressKey = table.Column<int>(nullable: false),
                    AdjustedGross = table.Column<double>(nullable: false),
                    AirConditioningCode = table.Column<string>(nullable: true),
                    ApnSequenceNo = table.Column<int>(nullable: false),
                    AppraisedImprovementValue = table.Column<double>(nullable: false),
                    AppraisedLandValue = table.Column<double>(nullable: false),
                    AppraisedTotalValue = table.Column<double>(nullable: false),
                    AssessedImprovementValue = table.Column<double>(nullable: false),
                    AssessedLandValue = table.Column<double>(nullable: false),
                    AssessedTotalValue = table.Column<double>(nullable: false),
                    Basement = table.Column<int>(nullable: false),
                    BasementCode = table.Column<string>(nullable: true),
                    BathFixtures = table.Column<int>(nullable: false),
                    Bedrooms = table.Column<int>(nullable: false),
                    BuildingArea = table.Column<int>(nullable: false),
                    BuildingAreaCode = table.Column<string>(maxLength: 1, nullable: true),
                    BuildingCode = table.Column<string>(nullable: true),
                    BuildingStyleCode = table.Column<string>(nullable: true),
                    CalculatedImprovementValue = table.Column<double>(nullable: false),
                    CalculatedImprovementValueCode = table.Column<string>(maxLength: 1, nullable: true),
                    CalculatedLandValue = table.Column<double>(nullable: false),
                    CalculatedLandValueCode = table.Column<string>(maxLength: 1, nullable: true),
                    CalculatedTotalValue = table.Column<double>(nullable: false),
                    CalculatedTotalValueCode = table.Column<string>(maxLength: 1, nullable: true),
                    CensusTract = table.Column<int>(nullable: false),
                    ConditionCode = table.Column<string>(nullable: true),
                    ConstructionCode = table.Column<string>(nullable: true),
                    CountyLandUse1 = table.Column<int>(nullable: false),
                    CountyLandUse2 = table.Column<int>(nullable: false),
                    DeedCategoryCode = table.Column<string>(nullable: true),
                    DeedTypeCode = table.Column<string>(nullable: true),
                    DepthFootage = table.Column<int>(nullable: false),
                    DocumentYear = table.Column<int>(nullable: false),
                    EffectiveYearBuilt = table.Column<int>(nullable: false),
                    ElectricityCode = table.Column<string>(nullable: true),
                    ExteriorWallCode = table.Column<string>(nullable: true),
                    FipsCode = table.Column<int>(nullable: false),
                    FipsSubCode = table.Column<string>(nullable: true),
                    Fireplace = table.Column<bool>(nullable: false),
                    FireplaceCode = table.Column<string>(nullable: true),
                    Fireplaces = table.Column<int>(nullable: false),
                    FlooringCode = table.Column<string>(maxLength: 1, nullable: true),
                    FormattedApn = table.Column<string>(nullable: true),
                    FoundationCode = table.Column<string>(nullable: true),
                    FrontFootage = table.Column<int>(nullable: false),
                    FuelCode = table.Column<string>(nullable: true),
                    FullBaths = table.Column<int>(nullable: false),
                    GarageCode = table.Column<string>(nullable: true),
                    GarageOrParking = table.Column<int>(nullable: false),
                    Gross = table.Column<int>(nullable: false),
                    GroundFloor = table.Column<int>(nullable: false),
                    HalfBaths = table.Column<int>(nullable: false),
                    HeatingCode = table.Column<string>(nullable: true),
                    HomesteadExempt = table.Column<bool>(nullable: false),
                    ImprovementCode = table.Column<string>(nullable: true),
                    LandUseCode = table.Column<int>(nullable: false),
                    LenderCode = table.Column<int>(nullable: false),
                    LenderName = table.Column<string>(nullable: true),
                    LivingSpace = table.Column<int>(nullable: false),
                    LocationInfluenceCode = table.Column<string>(nullable: true),
                    MarketImprovementValue = table.Column<double>(nullable: false),
                    MarketLandValue = table.Column<double>(nullable: false),
                    MarketTotalValue = table.Column<double>(nullable: false),
                    MobileHome = table.Column<bool>(nullable: false),
                    MortgageAmount = table.Column<double>(nullable: false),
                    MortgageAssumptionAmount = table.Column<double>(nullable: false),
                    MortgageDate = table.Column<DateTime>(nullable: false),
                    MortgageDeedTypeCode = table.Column<string>(nullable: true),
                    MortgageDueDate = table.Column<DateTime>(nullable: false),
                    MortgageLoanTypeCode = table.Column<string>(nullable: true),
                    MortgageTerm = table.Column<int>(nullable: false),
                    MortgageTermCode = table.Column<string>(maxLength: 1, nullable: true),
                    MultiApnCode = table.Column<string>(maxLength: 1, nullable: true),
                    MultiApnCount = table.Column<int>(nullable: false),
                    MunicipalityName = table.Column<string>(nullable: true),
                    NumberOfBuildings = table.Column<int>(nullable: false),
                    OneQuarterBaths = table.Column<int>(nullable: false),
                    OriginalApn = table.Column<int>(nullable: false),
                    ParkingCode = table.Column<string>(nullable: true),
                    ParkingSpaces = table.Column<int>(nullable: false),
                    ParsedRange = table.Column<int>(nullable: false),
                    Pool = table.Column<bool>(nullable: false),
                    PoolCode = table.Column<string>(nullable: true),
                    PostDirectional = table.Column<string>(nullable: true),
                    Predirectional = table.Column<string>(nullable: true),
                    PriorDeedCategoryCode = table.Column<int>(nullable: false),
                    PriorDocumentYear = table.Column<int>(nullable: false),
                    PriorMortgageAmount = table.Column<int>(nullable: false),
                    PriorMultiApnCode = table.Column<string>(maxLength: 1, nullable: true),
                    PriorMultiApnCount = table.Column<string>(nullable: true),
                    PriorRecordingDate = table.Column<DateTime>(nullable: false),
                    PriorSaleCode = table.Column<string>(maxLength: 1, nullable: true),
                    PriorSaleDate = table.Column<DateTime>(nullable: false),
                    PriorSalePrice = table.Column<double>(nullable: false),
                    PriorTransactionId = table.Column<int>(nullable: false),
                    PropertyResults = table.Column<string>(nullable: true),
                    QualityCode = table.Column<string>(nullable: true),
                    QuarterSection = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    RecordingDate = table.Column<DateTime>(nullable: false),
                    ResidentalModel = table.Column<string>(nullable: true),
                    RoofCoverCode = table.Column<int>(nullable: false),
                    RoofFramingCode = table.Column<string>(nullable: true),
                    RoofTypeCode = table.Column<string>(nullable: true),
                    SaleCode = table.Column<string>(maxLength: 1, nullable: true),
                    SaleDate = table.Column<DateTime>(nullable: false),
                    SalePrice = table.Column<double>(nullable: false),
                    SecondMortgageAmount = table.Column<double>(nullable: false),
                    SecondMortgageDeedTypeCode = table.Column<string>(nullable: true),
                    SecondMortgageLoanTypeCode = table.Column<string>(nullable: true),
                    Section = table.Column<int>(nullable: false),
                    SellerName = table.Column<string>(nullable: true),
                    SewerCode = table.Column<string>(nullable: true),
                    SquareFootage = table.Column<int>(nullable: false),
                    Stories = table.Column<int>(nullable: false),
                    StoriesCode = table.Column<string>(nullable: true),
                    Suffix = table.Column<string>(nullable: true),
                    SuiteName = table.Column<string>(nullable: true),
                    SuiteRange = table.Column<string>(nullable: true),
                    TaxAmount = table.Column<double>(nullable: false),
                    TaxYear = table.Column<int>(nullable: false),
                    ThreeQuarterBaths = table.Column<int>(nullable: false),
                    TotalBaths = table.Column<double>(nullable: false),
                    TotalBathsCalculated = table.Column<int>(nullable: false),
                    TotalRooms = table.Column<int>(nullable: false),
                    Township = table.Column<string>(nullable: true),
                    TransactionId = table.Column<int>(nullable: false),
                    TransactionId1 = table.Column<int>(nullable: false),
                    UnformattedApn = table.Column<int>(nullable: false),
                    Units = table.Column<int>(nullable: false),
                    UniversalBuilding = table.Column<int>(nullable: false),
                    ViewCode = table.Column<string>(nullable: true),
                    WaterCode = table.Column<string>(nullable: true),
                    YearBuilt = table.Column<int>(nullable: false),
                    Zoning = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDetails", x => x.PropertyIndicatorCode);
                    table.ForeignKey(
                        name: "FK_PropertyDetails_AddressDetails_AddressKey",
                        column: x => x.AddressKey,
                        principalTable: "AddressDetails",
                        principalColumn: "AddressKey",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyOwner",
                columns: table => new
                {
                    OwnerMatchCode = table.Column<string>(nullable: false),
                    PropertyIndicatorCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyOwner", x => new { x.OwnerMatchCode, x.PropertyIndicatorCode });
                    table.ForeignKey(
                        name: "FK_PropertyOwner_Owner_OwnerMatchCode",
                        column: x => x.OwnerMatchCode,
                        principalTable: "Owner",
                        principalColumn: "OwnerMatchCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PropertyOwner_PropertyDetails_PropertyIndicatorCode",
                        column: x => x.PropertyIndicatorCode,
                        principalTable: "PropertyDetails",
                        principalColumn: "PropertyIndicatorCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Owner_AddressKey",
                table: "Owner",
                column: "AddressKey");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_AddressKey",
                table: "PropertyDetails",
                column: "AddressKey");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyOwner_PropertyIndicatorCode",
                table: "PropertyOwner",
                column: "PropertyIndicatorCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyOwner");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropTable(
                name: "PropertyDetails");

            migrationBuilder.DropTable(
                name: "AddressDetails");
        }
    }
}
