using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RealCloud.Database.Migrations
{
    public partial class SecondMortgageTypesRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SecondMortgageLoanTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecondMortgageDeedTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_SecondMortgageDeedTypeCode",
                table: "PropertyDetails",
                column: "SecondMortgageDeedTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_SecondMortgageLoanTypeCode",
                table: "PropertyDetails",
                column: "SecondMortgageLoanTypeCode");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_MortgageDeedType_SecondMortgageDeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyDetails_MortgageLoanType_SecondMortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_SecondMortgageDeedTypeCode",
                table: "PropertyDetails");

            migrationBuilder.DropIndex(
                name: "IX_PropertyDetails_SecondMortgageLoanTypeCode",
                table: "PropertyDetails");

            migrationBuilder.AlterColumn<string>(
                name: "SecondMortgageLoanTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecondMortgageDeedTypeCode",
                table: "PropertyDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
