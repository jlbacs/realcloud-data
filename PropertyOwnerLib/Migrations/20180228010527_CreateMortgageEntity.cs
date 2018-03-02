using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Database.Migrations
{
    public partial class CreateMortgageEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_MortgageDeedType_MortgageDeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_MortgageLoanType_MortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_MortgageDeedType_SecondMortgageDeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_MortgageLoanType_SecondMortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyOwner_PropertyDetails_PropertyIndicatorCode",
                table: "PropertyOwner");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_MortgageDeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_MortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_SecondMortgageDeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_SecondMortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "MortgageAmount",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "MortgageAssumptionAmount",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "MortgageDate",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "MortgageDeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "MortgageDueDate",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "MortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "MortgageTerm",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "MortgageTermCode",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "PriorMortgageAmount",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "SecondMortgageAmount",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "SecondMortgageDeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "SecondMortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.RenameColumn(
                name: "PropertyIndicatorCode",
                table: "PropertyOwner",
                newName: "PropertyId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyOwner_PropertyIndicatorCode",
                table: "PropertyOwner",
                newName: "IX_PropertyOwner_PropertyId");

            migrationBuilder.RenameColumn(
                name: "PropertyIndicatorCode",
                table: "PropertyDetails",
                newName: "PropertyId");

            migrationBuilder.CreateTable(
                name: "Mortgage",
                columns: table => new
                {
                    MortgageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MortgageAmount = table.Column<double>(nullable: true),
                    MortgageAssumptionAmount = table.Column<double>(nullable: true),
                    MortgageDate = table.Column<DateTime>(nullable: true),
                    MortgageDeedTypeCode = table.Column<string>(nullable: true),
                    MortgageDueDate = table.Column<DateTime>(nullable: true),
                    MortgageLoanTypeCode = table.Column<string>(nullable: true),
                    MortgageTerm = table.Column<int>(nullable: true),
                    MortgageTermCode = table.Column<string>(maxLength: 1, nullable: true),
                    PriorMortgageAmount = table.Column<int>(nullable: true),
                    PropertyId = table.Column<int>(nullable: false),
                    SecondMortgageAmount = table.Column<double>(nullable: true),
                    SecondMortgageDeedTypeCode = table.Column<string>(nullable: true),
                    SecondMortgageLoanTypeCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mortgage", x => x.MortgageId);
                    table.ForeignKey(
                        name: "FK_Mortgage_MortgageDeedType_MortgageDeedTypeCode",
                        column: x => x.MortgageDeedTypeCode,
                        principalTable: "MortgageDeedType",
                        principalColumn: "MortgageDeedTypeCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mortgage_MortgageLoanType_MortgageLoanTypeCode",
                        column: x => x.MortgageLoanTypeCode,
                        principalTable: "MortgageLoanType",
                        principalColumn: "MortgageLoanTypeCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mortgage_PropertyDetails_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "PropertyDetails",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mortgage_MortgageDeedType_SecondMortgageDeedTypeCode",
                        column: x => x.SecondMortgageDeedTypeCode,
                        principalTable: "MortgageDeedType",
                        principalColumn: "MortgageDeedTypeCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mortgage_MortgageLoanType_SecondMortgageLoanTypeCode",
                        column: x => x.SecondMortgageLoanTypeCode,
                        principalTable: "MortgageLoanType",
                        principalColumn: "MortgageLoanTypeCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mortgage_MortgageDeedTypeCode",
                table: "Mortgage",
                column: "MortgageDeedTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Mortgage_MortgageLoanTypeCode",
                table: "Mortgage",
                column: "MortgageLoanTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Mortgage_PropertyId",
                table: "Mortgage",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Mortgage_SecondMortgageDeedTypeCode",
                table: "Mortgage",
                column: "SecondMortgageDeedTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Mortgage_SecondMortgageLoanTypeCode",
                table: "Mortgage",
                column: "SecondMortgageLoanTypeCode");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyOwner_PropertyDetails_PropertyId",
                table: "PropertyOwner",
                column: "PropertyId",
                principalTable: "PropertyDetails",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyOwner_PropertyDetails_PropertyId",
                table: "PropertyOwner");

            migrationBuilder.DropTable(
                name: "Mortgage");

            migrationBuilder.RenameColumn(
                name: "PropertyId",
                table: "PropertyOwner",
                newName: "PropertyIndicatorCode");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyOwner_PropertyId",
                table: "PropertyOwner",
                newName: "IX_PropertyOwner_PropertyIndicatorCode");

            migrationBuilder.RenameColumn(
                name: "PropertyId",
                table: "PropertyDetails",
                newName: "PropertyIndicatorCode");

            migrationBuilder.AddColumn<double>(
                name: "MortgageAmount",
                table: "PropertyDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MortgageAssumptionAmount",
                table: "PropertyDetails",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MortgageDate",
                table: "PropertyDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MortgageDeedTypeCode",
                table: "PropertyDetails",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "MortgageDueDate",
                table: "PropertyDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MortgageLoanTypeCode",
                table: "PropertyDetails",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MortgageTerm",
                table: "PropertyDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MortgageTermCode",
                table: "PropertyDetails",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PriorMortgageAmount",
                table: "PropertyDetails",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SecondMortgageAmount",
                table: "PropertyDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondMortgageDeedTypeCode",
                table: "PropertyDetails",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondMortgageLoanTypeCode",
                table: "PropertyDetails",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_MortgageDeedTypeCode",
                table: "PropertyDetails",
                column: "MortgageDeedTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_MortgageLoanTypeCode",
                table: "PropertyDetails",
                column: "MortgageLoanTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_SecondMortgageDeedTypeCode",
                table: "PropertyDetails",
                column: "SecondMortgageDeedTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_SecondMortgageLoanTypeCode",
                table: "PropertyDetails",
                column: "SecondMortgageLoanTypeCode");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_MortgageDeedType_MortgageDeedTypeCode",
                table: "PropertyDetails",
                column: "MortgageDeedTypeCode",
                principalTable: "MortgageDeedType",
                principalColumn: "MortgageDeedTypeCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_MortgageLoanType_MortgageLoanTypeCode",
                table: "PropertyDetails",
                column: "MortgageLoanTypeCode",
                principalTable: "MortgageLoanType",
                principalColumn: "MortgageLoanTypeCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_MortgageDeedType_SecondMortgageDeedTypeCode",
                table: "PropertyDetails",
                column: "SecondMortgageDeedTypeCode",
                principalTable: "MortgageDeedType",
                principalColumn: "MortgageDeedTypeCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyDetails_MortgageLoanType_SecondMortgageLoanTypeCode",
                table: "PropertyDetails",
                column: "SecondMortgageLoanTypeCode",
                principalTable: "MortgageLoanType",
                principalColumn: "MortgageLoanTypeCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyOwner_PropertyDetails_PropertyIndicatorCode",
                table: "PropertyOwner",
                column: "PropertyIndicatorCode",
                principalTable: "PropertyDetails",
                principalColumn: "PropertyIndicatorCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
